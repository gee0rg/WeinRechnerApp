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
    public partial class Verschnitt_Gesamtmenge : ContentPage
    {
        public Verschnitt_Gesamtmenge()
        {
            InitializeComponent();

        }

        Ergebnis_ges_VS ergebnis = new Ergebnis_ges_VS() { };
        // Ergebnis_Flaschen ergebnis2 = new Ergebnis_Flaschen() { };
        string err;
        string alert;
        async void Berechnen(object sender, EventArgs e)
        {
            if (!this.IsBusy)
            {

                try
                {
                    this.IsBusy = true;
                    berechnen_gesamt.IsVisible = false;


                    await Task.Run(() =>
                    {

                        request_ges_VS param = new request_ges_VS() { liter_gv = liter_gv.Text, restzucker_gw = restzucker_gw.Text, restzucker_verschnitt = restzucker_verschnitt.Text, restzucker_vw = restzucker_vw.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();

                        String answer;
                        String adress = "http://localhost:50088/api/ges_Vs";
                        answer = rconn.HTTP_POST(adress, request, 5, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {
                            double eingabe_user_liter_gv;
                            double eingabe_user_restzucker_gw;
                            double eingabe_user_restzucker_verschnitt;
                            double eingabe_user_vw;
                            try
                            {
                                eingabe_user_liter_gv = Convert.ToDouble(liter_gv.Text);
                                eingabe_user_restzucker_gw = Convert.ToDouble(restzucker_gw.Text);
                                eingabe_user_restzucker_verschnitt = Convert.ToDouble(restzucker_verschnitt.Text);
                                eingabe_user_vw = Convert.ToDouble(restzucker_vw.Text);
                            }
                            catch
                            {
                                err = "Es sind Zahlen einzugeben";
                                return;
                            }
                            if (eingabe_user_liter_gv < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }
                            if (eingabe_user_restzucker_gw < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }
                            if (eingabe_user_restzucker_verschnitt < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }
                            if (eingabe_user_vw < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }

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
                                err = "Eingabe prüfen";
                                return;

                            }
                            if (x1 >= 0)
                            { }
                            else
                            {
                                err = "Eingabe prüfen";
                                return;
                            }
                            if (x2 >= 0)
                            { }
                            else
                            {
                                err = "Eingabe prüfen";
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
                                err = "Eingabe prüfen";
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
                                alert = "Falls es sich beim Verschnittpartner um Wein handelt, ist der max. Verschnitt von 15% überschritten";



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
                                alert = "Falls es sich beim Verschnittpartner um Süßreserve handelt, ist der max. Verschnitt von 25% überschritten";


                            }
                        }
                        else
                        {
                            gesVSRestResponse erg = new gesVSRestResponse() { };
                            erg = JsonConvert.DeserializeObject<gesVSRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                //Eventstatus auswerten und dann alert oder err belegen

                                return;
                            }
                            ergebnis.liter_gw = erg.liter_gw;
                            ergebnis.liter_gw_prozent = erg.liter_gw_prozent;
                            ergebnis.liter_vw = erg.liter_vw;
                            ergebnis.liter_vw_prozent = erg.liter_vw_prozent;
                        }
                    });

                }
                finally
                {
                    this.IsBusy = false;
                    berechnen_gesamt.IsVisible = true;
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;

                    }
                    else
                    {

                        if (!string.IsNullOrEmpty(alert))
                        {
                            await DisplayAlert("Hinweis", alert, "OK");
                            alert = null;

                        }
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Ges(ergebnis, liter_gv.Text)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }
        }
    }
}