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

        void NutzungsbedingungenButton_Clicked(object sender, EventArgs e)
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
            string adress = "http://10.141.77.226:4438/api/Nutzerbendingungen";
            //string adress = "http://localhost:50088/api/Usermanagment";
            //bool a = Online.OnlineStatus(adress);

            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                //kein Antwort vom Webservice user muss Nutzungsbedingungen zustimmen
                //Navigation.PushModalAsync(new Nutzungsbedingungen());
               
                Navigation.PushModalAsync(new MasterDetailPage1());
            }
            else
            {
                Navigation.PushModalAsync(new MasterDetailPage1());

                erg = JsonConvert.DeserializeObject<User_Response>(answer);
                if (erg.EventStatus == -1)
                {
                    //rest aufruf war fail
                    Navigation.PushModalAsync(new MasterDetailPage1());
                }
                else
                {
                    Navigation.PushModalAsync(new MasterDetailPage1());
                }
            }
        }
    }
}