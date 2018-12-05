using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.ViedwModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Weinrechnerlel.Models;
using Newtonsoft.Json;
using Weinrechnerlel.Helper;

namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Startpage : ContentPage
    {
        public Startpage()
        {

            InitializeComponent();
          
            //BindingContext = new StartViewModel(Navigation);
         
            balken.IsRunning = false;
            los.IsVisible = true;

        }

         void StartButton_Clicked (object sender, EventArgs e)
       {


           
           

            string ids;
           if (Application.Current.Properties.ContainsKey("id"))
           {


               ids = Convert.ToString(Application.Current.Properties["id"]);
           }
           else
           {
               ids = "0";
           }
            request_User param = new request_User() { Id = ids };
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();
          User_Response erg = new User_Response() { };
          string answer;
            string adress = "http://10.141.77.226:4438/api/UsersManagment";
            //string adress = "http://localhost:50088/api/Usermanagment";
            bool a = Online.OnlineStatus(adress);
            if (a == true)
            {
                answer =  rconn.HTTP_POST(adress, request, 5, false);
                if (answer.Contains("REST_HTTP_ERROR"))
                {
                    //kein Antwort vom Webservice user muss Nutzungsbedingungen zustimmen
                    //Navigation.PushModalAsync(new Nutzungsbedingungen());
                    erg.id = "";
                     Navigation.PushModalAsync(new Nutzungsbedingungen(erg));
                }






               erg = JsonConvert.DeserializeObject<User_Response>(answer);
                if (erg.EventStatus == 1)
                {
                    Application.Current.Properties.Clear();
                    Application.Current.Properties.Add("id", erg.id);
                     Application.Current.SavePropertiesAsync();
                }
                if (erg.EventStatus == -1)
                {
                    //gab einen Fehler User wurde nicht gefunden oder in DB eingetragen --muss daher Nutzerbedignugen zustimmen
                     Navigation.PushModalAsync(new Nutzungsbedingungen(erg));

                }
                if (erg.Nutzung == true)
                {
                    //User wurd erkannt und hat bereits den Bedingeunen zusgestimmt er kann die App sofort nutzen
                     Navigation.PushModalAsync(new MasterDetailPage1());
                }
                else
                {
                    //User wurde erkannt oder neu angelegt und hat den Nutzerbedignugen noch nicht zusgtstimmt und muss dies erst machen bevor er die App nutzen kann
                     Navigation.PushModalAsync(new Nutzungsbedingungen(erg));
                }


            }
            else
            {
                //kein Antwort vom Webservice user muss Nutzungsbedingungen zustimmen
                //Navigation.PushModalAsync(new Nutzungsbedingungen());
                erg.id = "";
              Navigation.PushModalAsync(new Nutzungsbedingungen(erg));
            }






          


        }

        //private void los_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
          
        //    balken.IsRunning = false;
        //    los.IsVisible = true;
        //}

        //private void los_PropertyChanging(object sender, PropertyChangingEventArgs e)
        //{
        //    balken.IsRunning = true;
        //    los.IsVisible = false;
        //}
    }
}