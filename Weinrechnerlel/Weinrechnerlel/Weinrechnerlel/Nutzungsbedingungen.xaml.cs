using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nutzungsbedingungen : ContentPage
    {
        string user;
        public Nutzungsbedingungen()
        {
            InitializeComponent();
            UserManagment.IsVisible = false;
        }

        public Nutzungsbedingungen(User_Response user = null)
        {
            //anzeige der Nutzungsbedingungen
            InitializeComponent();
            if (user != null)
            {
                UserManagment.IsVisible = true;
                this.user = user.id;
            }
            else
            {
                UserManagment.IsVisible = false;
            }
        }

        async void NutzungsbedingungenButton_Clicked(object sender, EventArgs e)
        {
         

            if (!this.IsBusy)
            {
                try
                {
                    //Ladebalken startet
                    this.IsBusy = true;
                    UserManagment.IsVisible = false;

                    await Task.Run(() =>
                    {
                        //schaut nach id
                        bool ids;
                        if (Application.Current.Properties.ContainsKey("Zst"))
                        {
                            ids = Convert.ToBoolean(Application.Current.Properties["Zst"]);

                           
                        }
                        else
                        {
                            ids = false;
                        }
                        if (ids == false)
                        {
                            ids = true;
                        }
                        if (ids == true) {
                            Application.Current.Properties.Clear();
                            Application.Current.Properties["Zst"] = "true";
                            }

                        //restaufruf
                        //request_User param = new request_User() { Id = ids };
                        //String request = JsonConvert.SerializeObject(param);
                        //RESTConnector rconn = new RESTConnector();
                        //User_Response erg = new User_Response() { };
                        //string answer;
                        //string adress = "http://192.168.178.41:4438/api/Nutzungsbedinungen";

                        //Speicherung das der Nutzer den Bed. zugestimmt hat
                        //answer = rconn.HTTP_POST(adress, request, 50, false);

                    });

                }
                //Weiterleitung zum Hauptmenü
                //Ladenbalken schließt
                finally
                {                    
                    this.IsBusy = false;
                    UserManagment.IsVisible = true;
                    await Navigation.PushModalAsync(new MasterDetailPage1());

                }
            }
        }
    }
}