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

        string err;

        Ergebnis_Aust_VS ergebnis = new Ergebnis_Aust_VS();


        async void Berechnen_Austausch(Object sender, EventArgs e)
        {
            err = null;

            if (!this.IsBusy)
            {
                //Ladebalken startet
                try
                {
                    this.IsBusy = true;
                    berechnen_austausch.IsVisible = false;

                    await Task.Run(() =>
                    {
                        //Validierungen
                        double eingabe_user_liter_gw;

                        try
                        {
                            eingabe_user_liter_gw = Convert.ToDouble(liter_gw.Text);

                        }
                        catch
                        {
                            err = "Es sind Zahlen einzugeben";
                            return;
                        }
                        if (string.IsNullOrEmpty(liter_gw.Text))
                        {
                            err = "Es sind Zahlen einzugeben";
                            return;
                        }
                        if (eingabe_user_liter_gw < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        } 
                        //Restaufruf
                        request_aust_VS param = new request_aust_VS() { liter_gw = liter_gw.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();
                        Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
                        String answer;
                        String adress = "http://10.141.69.156:4438/api/aust_VS";

                        answer = rconn.HTTP_POST(adress, request, 50, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {
                            //Restaufruf timeout
                            err= "Keine Verbindung zum Server";
                            
                            //    double eingabe_user_liter_gw;

                            //    try
                            //    {
                            //        eingabe_user_liter_gw = Convert.ToDouble(liter_gw.Text);

                            //    }
                            //    catch
                            //    {
                            //        err = "Es sind Zahlen einzugeben";
                            //        return;
                            //    }
                            //    if (string.IsNullOrEmpty(liter_gw.Text))
                            //    {
                            //        err = "Es sind Zahlen einzugeben";
                            //        return;
                            //    }
                            //    if (eingabe_user_liter_gw < 0)
                            //    {
                            //        err = "Ihre Eingabe muss positiv sein";
                            //        return;
                            //    }

                            //    //Teil 1
                            //    double a = Convert.ToDouble(liter_gw.Text) / 0.85 - Convert.ToDouble(liter_gw.Text);
                            //    double b = Math.Floor(a);
                            //    ergebnis.max_vw = Convert.ToInt32(b);
                            //    //Console.WriteLine(ergebnis.max_vw);

                            //    double c = Convert.ToDouble(liter_gw.Text) / 0.75 - (Convert.ToDouble(liter_gw.Text) + ergebnis.max_vw);
                            //    double d = Math.Floor(c);
                            //    ergebnis.max_sr1 = Convert.ToInt32(d);
                            //    //Console.WriteLine(ergebnis.max_sr1);
                            //}
                        }
                        else
                        {
                            //Auswertung des Restaufrufes wenn kein Timout
                            AustVSRestResponse erg = new AustVSRestResponse() { };
                            erg = JsonConvert.DeserializeObject<AustVSRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                err = erg.EventMessage;
                                return;
                            }
                            //umspeichern der Ergebnisse
                            ergebnis.max_sr1 = erg.max_sr1;
                            ergebnis.max_vw = erg.max_vw;
                        }
                    });
                }
                //Ladebalken schließt
                finally
                
                //ggf werden Fehler dargestellt
                {
                    this.IsBusy = false;
                    berechnen_austausch.IsVisible = true;
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;
                    }
                    //Weiterreichen der Ergebisse an Ergebnisseite zur Dartsellung
                    else
                    {
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Aust(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }
        }
    }
}
