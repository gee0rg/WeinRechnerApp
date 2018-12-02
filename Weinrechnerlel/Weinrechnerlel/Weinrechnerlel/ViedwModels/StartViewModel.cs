using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Weinrechnerlel.Models;
using Xamarin.Forms;

namespace Weinrechnerlel.ViedwModels
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _balken;
        private bool _los;

        public StartViewModel()
        {
            Go = new Command(goes, _GO);
        }

        public Command Go { get; set; }

        public INavigation Navigation { get; set; }



        public StartViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            Go = new Command(goes);
        }

        public void goes()
        {
            
                Balken = true;
                Los = false;

          
        }



        private bool _GO()
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


            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                //kein Antwort vom Webservice user muss Nutzungsbedingungen zustimmen
                //Navigation.PushModalAsync(new Nutzungsbedingungen());
                erg.id = "";
                Navigation.PushModalAsync(new Nutzungsbedingungen(erg));
                return true;

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
                Balken = false;
                Los = true;
                return true;

            }
            if (erg.Nutzung == true)
            {
                //User wurd erkannt und hat bereits den Bedingeunen zusgestimmt er kann die App sofort nutzen
                Navigation.PushModalAsync(new MasterDetailPage1());
                Balken = false;
                Los = true;
                return true;
            }
            else
            {
                //User wurde erkannt oder neu angelegt und hat den Nutzerbedignugen noch nicht zusgtstimmt und muss dies erst machen bevor er die App nutzen kann
                Navigation.PushModalAsync(new Nutzungsbedingungen(erg));
                Balken = false;
                Los = true;
                return true;
            }


            
        }












        public bool Balken
        {
            get => _balken; set
            {
                _balken = value;
                OnPropertyChanged();
            }
        }

        public bool Los
        {
            get => _los; set
            {
                _los = value;
                OnPropertyChanged();
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
