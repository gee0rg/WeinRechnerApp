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
    public partial class Verschnitt_Rueck : ContentPage
    {
        public Verschnitt_Rueck()
        {
            InitializeComponent();
        }

        string err;
        Ergebnis_rueck_VS ergebnis = new Ergebnis_rueck_VS() { };

        async void berechnen(Object sender, EventArgs e)
        {
            err = null;
            if (!this.IsBusy)
            {

                try
                {
                    this.IsBusy = true;
                    berechnen_rueck.IsVisible = false;

                    await Task.Run(() =>
                    {

                        request_rueck_VS param = new request_rueck_VS() { liter_vw = liter_vw.Text, liter_sr = liter_sr.Text, liter_ges_vw = liter_ges_vw.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();
                        Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
                        String answer;
                        String adress = "http://localhost:50088/api/basis_Vs";

                        answer = rconn.HTTP_POST(adress, request, 5, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {

                            double eingabe_user_liter_vw;
                            double eingabe_user_liter_sr;
                            double eingabe_user_liter_ge_vw;

                            try
                            {
                                eingabe_user_liter_vw = Convert.ToDouble(liter_vw.Text);
                                eingabe_user_liter_sr = Convert.ToDouble(liter_sr.Text);
                                eingabe_user_liter_ge_vw = Convert.ToDouble(liter_ges_vw.Text);
                            }
                            catch
                            {
                                err = "Es sind Zahlen einzugeben";
                                return;
                            }
                            if (string.IsNullOrEmpty(liter_vw.Text))
                            {
                                err = "Es sind Zahlen einzugeben";
                                return;
                            }
                            if (string.IsNullOrEmpty(liter_sr.Text))
                            {
                                err = "Es sind Zahlen einzugeben";
                                return;
                            }
                            if (string.IsNullOrEmpty(liter_ges_vw.Text))
                            {
                                err = "Es sind Zahlen einzugeben";
                                return;
                            }
                            if (eingabe_user_liter_vw < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }
                            if (eingabe_user_liter_sr < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }
                            if (eingabe_user_liter_ge_vw < 0)
                            {
                                err = "Ihre Eingabe muss positiv sein";
                                return;
                            }

                            //Teil1
                            double x1 = (Convert.ToDouble(liter_vw.Text) / 15) * 85;
                            ergebnis.be_gw_mitSr_1 = Convert.ToInt32(Math.Floor(x1));

                            double x2 = x1 / 0.75 - Convert.ToDouble(liter_vw.Text) - x1;
                            ergebnis.max_sr1 = Convert.ToInt32(Math.Floor(x2));

                            double x3 = x1 / 0.75;
                            ergebnis.ges_menge_mitSr_1 = Convert.ToInt32(Math.Floor(x3));

                            double x4 = x1;
                            ergebnis.be_gw_ohneSr_1 = Convert.ToInt32(Math.Floor(x4));

                            double x5 = x1 + Convert.ToDouble(liter_vw.Text);
                            ergebnis.ges_menge_ohneSr_1 = Convert.ToInt32(Math.Floor(x5));

                            //Teil2
                            double x6 = (Convert.ToDouble(liter_sr.Text) / 25) * 75;
                            ergebnis.be_gw_2 = Convert.ToInt32(Math.Floor(x6));

                            double x7 = x6 / 0.75;
                            ergebnis.ges_menge_2 = Convert.ToInt32(Math.Floor(x7));

                            //Teil3
                            double x8 = (Convert.ToDouble(liter_ges_vw.Text) / 100) * 75;
                            ergebnis.be_gw_mitSr_3 = Convert.ToInt32(Math.Floor(x8));

                            double x10 = x8 / 0.85 - x8;
                            ergebnis.max_vw_mitSr_3 = Convert.ToInt32(Math.Floor(x10));

                            double x9 = x8 / 0.75 - x10 - x8;
                            ergebnis.max_sr3 = Convert.ToInt32(Math.Floor(x9));
                            //In der Ausgabereihenfolge eigentlich umgekehrt

                            double x11 = (Convert.ToDouble(liter_ges_vw.Text) / 100) * 85;
                            ergebnis.be_gw_ohneSr_3 = Convert.ToInt32(Math.Floor(x11));

                            double x12 = Convert.ToDouble(liter_ges_vw.Text) - x11;
                            ergebnis.max_vw_ohneSr_3 = Convert.ToInt32(Math.Floor(x12));
                        }

                        else
                        {
                            RueckVSRestResponse erg = new RueckVSRestResponse() { };
                            erg = JsonConvert.DeserializeObject<RueckVSRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                err = erg.EventMessage;
                                return;
                            }

                            ergebnis.be_gw_2 = erg.be_gw_2;
                            ergebnis.be_gw_mitSr_1 = erg.be_gw_mitSr_1;
                            ergebnis.be_gw_mitSr_3 = erg.be_gw_mitSr_3;
                            ergebnis.be_gw_ohneSr_1 = erg.be_gw_ohneSr_1;
                            ergebnis.be_gw_ohneSr_3 = erg.be_gw_ohneSr_3;
                            ergebnis.ges_menge_2 = erg.ges_menge_2;
                            ergebnis.ges_menge_mitSr_1 = erg.ges_menge_mitSr_1;
                            ergebnis.ges_menge_ohneSr_1 = erg.ges_menge_ohneSr_1;
                            ergebnis.max_sr1 = erg.max_sr1;
                            ergebnis.max_sr3 = erg.max_sr3;
                            ergebnis.max_vw_mitSr_3 = erg.max_vw_mitSr_3;
                            ergebnis.max_vw_ohneSr_3 = erg.max_vw_ohneSr_3;
                        }
                    });
                }
                finally
                {
                    this.IsBusy = false;
                    berechnen_rueck.IsVisible = true;
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;
                    }
                    else
                    {
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Rueck(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }
        }
    }
}