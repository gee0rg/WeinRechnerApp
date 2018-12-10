using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Weinrechnerlel.Models;
using Newtonsoft.Json;


namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verschnitt_Aust : ContentPage
    {
        public Verschnitt_Aust()
        {
            InitializeComponent();
        }

        Ergebnis_Aust_VS ergebnis = new Ergebnis_Aust_VS();


        void Berechnen_Austausch(Object sender, EventArgs e) {


            request_aust_VS param = new request_aust_VS() { liter_gw = liter_gw.Text};
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();
            Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
            String answer;
            String adress = "http://localhost:50088/api/aust_Vs";

            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                double eingabe_user_liter_gw;
                
                try
                {
                    eingabe_user_liter_gw = Convert.ToDouble(liter_gw.Text);
                    
                }
                catch
                {
                    DisplayAlert("Hinweis", "Es sind Zahlen einzugeben", "OK");
                    return;
                }
                if (eingabe_user_liter_gw < 0)
                {
                    DisplayAlert("Hinweis", "Ihre Eingabe muss positiv sein", "OK");
                    return;
                }
                
               


                //Teil 1
                double a = Convert.ToDouble(liter_gw.Text) / 0.85 - Convert.ToDouble(liter_gw.Text);
                double b = Math.Floor(a);
                ergebnis.max_vw = Convert.ToInt32(b);
                //Console.WriteLine(ergebnis.max_vw);

                double c = Convert.ToDouble(liter_gw.Text) / 0.75 - (Convert.ToDouble(liter_gw.Text) + ergebnis.max_vw);
                double d = Math.Floor(c);
                ergebnis.max_sr1 = Convert.ToInt32(d);
                //Console.WriteLine(ergebnis.max_sr1);
            }
            else
            {
                AustVSRestResponse erg = new AustVSRestResponse() { };
                erg = JsonConvert.DeserializeObject<AustVSRestResponse>(answer);
                if (erg.EventStatus != 0)
                {
                    DisplayAlert("Hinweis", erg.EventMessage, "OK");

                    return;
                }
                ergebnis.max_sr1 = erg.max_sr1;
                
                ergebnis.max_vw = erg.max_vw;

            }
                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Aust(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);


                

               
            

        }
    }
}
