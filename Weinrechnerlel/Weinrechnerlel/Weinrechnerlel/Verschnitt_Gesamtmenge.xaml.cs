using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Weinrechnerlel.Models;
using Newtonsoft.Json;
using WeinrechnerCommon;

namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Verschnitt_Gesamtmenge : ContentPage
    {
        public Verschnitt_Gesamtmenge()
        {
            InitializeComponent();

        }

        Ergebnis_ges_VS ergebnis = new Ergebnis_ges_VS() { };
        Ergebnis_Flaschen ergebnis2 = new Ergebnis_Flaschen() { };

        void Berechnen(object sender, EventArgs e)

        {
            request_ges_VS param = new request_ges_VS() { liter_gv = liter_gv.Text, restzucker_gw = restzucker_gw.Text, restzucker_verschnitt = restzucker_verschnitt.Text, restzucker_vw=restzucker_vw.Text };
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();
           
            String answer;
            String adress = "http://localhost:50088/api/ges_Vs";
            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {

                //1. Berechnung
                double x1 = Convert.ToDouble(restzucker_vw.Text) - Convert.ToDouble(restzucker_verschnitt.Text);
                double x2 = Convert.ToDouble(restzucker_verschnitt.Text) - Convert.ToDouble(restzucker_gw.Text);
                double x3 = x1 + x2;
                double x4 = Convert.ToDouble(liter_gv.Text) / x3;
                double x5 = x4 * x1;
                double x6 = x4 * x2;
                // double x7 = x5 + x6;

                //2. Prüfung
                if (Convert.ToDouble(restzucker_gw.Text) <= Convert.ToDouble(restzucker_verschnitt.Text))
                { }
                else
                {
                    DisplayAlert("Alert", "Eingabe prüfen", "OK");
                    return;

                }
                if (x1 >= 0)
                { }
                else
                {
                    DisplayAlert("Alert", "Eingabe prüfen", "OK");
                    return;
                }
                if (x2 >= 0)
                { }
                else
                {
                    DisplayAlert("Alert", "Eingabe prüfen", "OK");
                    return;
                }
                if (x1 > 0 && x2 > 0)
                {
                    ergebnis.liter_gw = Convert.ToInt32(x5);
                    ergebnis.liter_vw = Convert.ToInt32(x6);
                    Console.WriteLine(ergebnis.liter_gw);
                    Console.WriteLine(ergebnis.liter_vw);

                }
                else
                {
                    DisplayAlert("Alert", "Eingabe prüfen", "OK");
                    return;
                }




                //3. % Prüfung
                double x8 = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                if (x8 <= 15.00)
                {
                    double a = x5 / (Convert.ToDouble(liter_gv.Text) / 100);
                    double b = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                    ergebnis.liter_gw_prozent = Math.Round(a, 1);
                    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                    // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                    //Console.WriteLine(ergebnis.liter_vw_prozent + " %");

                    NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Ges(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                    Navigation.PushAsync(nav);

                }
                else if (x8 > 15.00 && x8 <= 25.00)
                {
                    double a = x5 / (Convert.ToDouble(liter_gv.Text) / 100);
                    double b = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                    ergebnis.liter_gw_prozent = Math.Round(a, 1);
                    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                    // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                    // Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                    //Console.WriteLine("15% Meldung");
                    DisplayAlert("Alert", "Falls es sich beim Verschnittpartner um Wein handelt, ist der max. Verschnitt von 15% überschritten", "OK");


                    NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Ges(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                    Navigation.PushAsync(nav);

                }
                else if (x8 > 25.00)
                {
                    double a = x5 / (Convert.ToDouble(liter_gv.Text) / 100);
                    double b = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                    ergebnis.liter_gw_prozent = Math.Round(a, 1);
                    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                    //Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                    //Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                    //Console.WriteLine("25% Meldung");
                    DisplayAlert("Alert", "Falls es sich beim Verschnittpartner um Süßreserve handelt, ist der max. Verschnitt von 25% überschritten", "OK");
                    NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Ges(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                    Navigation.PushAsync(nav);

                }
            }
             else
            {
                gesVSRestResponse erg = new gesVSRestResponse() { };
                erg = JsonConvert.DeserializeObject<gesVSRestResponse>(answer);
                if (erg.EventStatus != 0)
                {
                    DisplayAlert("Alert", erg.EventMessage, "OK");

                    return;
                }
                ergebnis.liter_gw = erg.liter_gw;
                ergebnis.liter_gw_prozent = erg.liter_gw_prozent;
                ergebnis.liter_vw = erg.liter_vw;
                ergebnis.liter_vw_prozent = erg.liter_vw_prozent;

                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Ges(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);

            }

          
        }

        void berechnen2(Object sender, EventArgs e)
        {

            // Console.WriteLine("ergibt Flaschen: ");
            //Console.WriteLine(ergebnis.liter_gw);
            double x = Convert.ToDouble(ergebnis.liter_gw) / 0.75;
            // Console.WriteLine(Convert.ToInt32(x));
            double y = Convert.ToDouble(ergebnis.liter_gw) / 0.5;
            //Console.WriteLine(Convert.ToInt32(y));
            double z = Convert.ToDouble(ergebnis.liter_gw) / 0.375;
            // Console.WriteLine(Convert.ToInt32(z));


            double a = Convert.ToDouble(ergebnis.liter_gw) - (Convert.ToDouble(verw_liter1.Text) + Convert.ToDouble(verw_liter075.Text) * 0.75 + Convert.ToDouble(verw_liter05.Text) * 0.5 + Convert.ToDouble(verw_liter0375.Text) * 0.375);
            ergebnis2.rest_liter = a;
            ergebnis2.verb_liter1 = ergebnis2.rest_liter;
            ergebnis2.verb_liter075 = ergebnis2.rest_liter / 0.75;
            ergebnis2.verb_liter05 = ergebnis2.rest_liter / 0.5;
            ergebnis2.verb_liter0375 = ergebnis2.rest_liter / 0.375;

            /* Console.WriteLine("verbleibende Flaschen: ");
             Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter1));
             Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter075));
             Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter05));
             Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter0375));
             Console.WriteLine("Restmenge in Litern: " + Convert.ToInt32(ergebnis2.rest_liter));*/

        }

    }
}