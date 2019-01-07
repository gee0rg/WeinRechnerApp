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
    public partial class Verschnitt_Basis : ContentPage
    {
        public Verschnitt_Basis()
        {
            InitializeComponent();
        }
        Ergebnis_grw_VS ergebnis = new Ergebnis_grw_VS() { };
        // Ergebnis_Flaschen ergebnis2 = new Ergebnis_Flaschen() { };
        string err;
        string alert;
        async void berechnen(object sender, EventArgs e)
        {
           
            if (!this.IsBusy)
            {

                try
                {
                    this.IsBusy = true;
                    berechnen_basis.IsVisible = false;


                    await Task.Run(() =>
                    {
                        double eingabe_user_liter_gw;
                        double eingabe_user_restzucker_gw;
                        double eingabe_user_restzucker_sr;
                        double eingabe_user_restzucker_verschnitt;
                        try
                        {
                            eingabe_user_liter_gw = Convert.ToDouble(liter_gw.Text);
                            eingabe_user_restzucker_gw = Convert.ToDouble(restzucker_gw.Text);
                            eingabe_user_restzucker_sr = Convert.ToDouble(restzucker_sr.Text);
                            eingabe_user_restzucker_verschnitt = Convert.ToDouble(restzucker_verschnitt.Text);
                        }
                        catch
                        {
                            err = "Es sind Zahlen einzugeben";
                            // DisplayAlert("Hinweis", "Es sind Zahlen einzugeben", "OK");
                            return;
                        }
                        if (eingabe_user_liter_gw < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }
                        if (eingabe_user_restzucker_gw < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }
                        if (eingabe_user_restzucker_sr < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }
                        if (eingabe_user_restzucker_verschnitt < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }

                        request_basis_Vs param = new request_basis_Vs() { liter_gw = liter_gw.Text, restzucker_gw = restzucker_gw.Text, restzucker_sr = restzucker_sr.Text, restzucker_verschnitt = restzucker_verschnitt.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();
                        Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
                        String answer;
                        String adress = "http://10.141.69.156:4438/api/grw_VS";

                        answer = rconn.HTTP_POST(adress, request, 5, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {
                            err = "Keine Verbindung zum Server";
                            
                            //double eingabe_user_liter_gw;
                            //double eingabe_user_restzucker_gw;
                            //double eingabe_user_restzucker_sr;
                            //double eingabe_user_restzucker_verschnitt;
                            //try
                            //{
                            //    eingabe_user_liter_gw = Convert.ToDouble(liter_gw.Text);
                            //    eingabe_user_restzucker_gw = Convert.ToDouble(restzucker_gw.Text);
                            //    eingabe_user_restzucker_sr = Convert.ToDouble(restzucker_sr.Text);
                            //    eingabe_user_restzucker_verschnitt = Convert.ToDouble(restzucker_verschnitt.Text);
                            //}
                            //catch
                            //{
                            //    err = "Es sind Zahlen einzugeben";
                            //   // DisplayAlert("Hinweis", "Es sind Zahlen einzugeben", "OK");
                            //    return;
                            //}
                            //if (eingabe_user_liter_gw < 0)
                            //{
                            //    err = "Ihre Eingabe muss positiv sein";
                            //    return;
                            //}
                            //if (eingabe_user_restzucker_gw < 0)
                            //{
                            //    err = "Ihre Eingabe muss positiv sein";
                            //    return;
                            //}
                            //if (eingabe_user_restzucker_sr < 0)
                            //{
                            //    err = "Ihre Eingabe muss positiv sein";
                            //    return;
                            //}
                            //if (eingabe_user_restzucker_verschnitt < 0)
                            //{
                            //    err = "Ihre Eingabe muss positiv sein";
                            //    return;
                            //}

                            //1. Berechnung
                            //double m4 = Convert.ToDouble(restzucker_sr.Text) - Convert.ToDouble(restzucker_verschnitt.Text);
                            //double m6 = Convert.ToDouble(restzucker_verschnitt.Text) - Convert.ToDouble(restzucker_gw.Text);
                            //double n4 = Convert.ToDouble(liter_gw.Text) / m4;
                            //double o6 = m6 * n4;
                            //double e1 = Convert.ToDouble(liter_gw.Text) + o6;
                            //double e2 = o6;

                            ////2. Prüfung
                            //if (Convert.ToDouble(restzucker_gw.Text) <= Convert.ToDouble(restzucker_verschnitt.Text))
                            //{ }
                            //else
                            //{
                            //    err = "Eingabe prüfen";
                            //    return;

                            //}
                            //if (m4 >= 0)
                            //{ }
                            //else
                            //{
                            //    err = "Eingabe prüfen";
                            //    return;
                            //}
                            //if (m6 >= 0)
                            //{ }
                            //else
                            //{
                            //    err = "Eingabe prüfen";
                            //    return;
                            //}
                            //if (m4 > 0 && m6 > 0)
                            //{
                            //    ergebnis.liter_gw = Convert.ToInt32(e1);
                            //    ergebnis.liter_vw = Convert.ToInt32(e2);
                            //    Console.WriteLine(ergebnis.liter_gw);
                            //    Console.WriteLine(ergebnis.liter_vw);

                            //}
                            //else
                            //{
                            //    err = "Eingabe prüfen";
                            //    return;
                            //}




                            ////3. % Prüfung
                            //double x8 = o6 / (e1 / 100);
                            ////double b;
                            //if (x8 <= 15.00)
                            //{
                            //    double b = o6 / (e1 / 100);
                            //    ergebnis.liter_gw_prozent = 100;
                            //    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                            //    //Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                            //    //Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                            //    //return ergebnis;

                            //}
                            //else if (x8 > 15.00 && x8 <= 25.00)
                            //{
                            //    double b = o6 / (e1 / 100);
                            //    ergebnis.liter_gw_prozent = 100;
                            //    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                            //    // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                            //    // Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                            //    // Console.WriteLine("15% Meldung");
                            //    alert = "Falls es sich beim Verschnittpartner um Wein handelt, ist der max. Verschnitt von 15% überschritten";
                            //    // return ergebnis;

                            //}
                            //else if (x8 > 25.00)
                            //{
                            //    double b = o6 / (e1 / 100);
                            //    ergebnis.liter_gw_prozent = 100;
                            //    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                            //    // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                            //    // Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                            //    // Console.WriteLine("25% Meldung");
                            //    alert = "Falls es sich beim Verschnittpartner um Süßreserve handelt, ist der max. Verschnitt von 25% überschritten";
                            //    // return ergebnis;

                            //}
                        }
                        else
                        {
                            BasisVsRestResponse erg = new BasisVsRestResponse() { };
                            erg = JsonConvert.DeserializeObject<BasisVsRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                if (erg.EventStatus==1)
                                {
                                    alert = erg.EventMessage;
                                }
                                else
                                {
                                    err = erg.EventMessage;
                                }

                                
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
                    berechnen_basis.IsVisible = true;
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;

                    }
                    else
                    {

                        if (!string.IsNullOrEmpty(alert)){
                            await DisplayAlert("Hinweis", alert, "OK");
                            alert = null;
                        }
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Basis(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }

            /*void berechnen2 (Object sender, EventArgs e)
            {
                    double a = Convert.ToDouble(ergebnis.liter_gw) - (Convert.ToDouble(verw_liter1.Text) + Convert.ToDouble(verw_liter075.Text) * 0.75 + Convert.ToDouble(verw_liter05.Text) * 0.5 + Convert.ToDouble(verw_liter0375.Text) * 0.375);
                    ergebnis.rest_liter = Math.Floor(a);
                    ergebnis.verb_liter1 = Math.Floor(ergebnis.rest_liter);
                    ergebnis.verb_liter075 = Math.Floor(ergebnis.rest_liter / 0.75);
                    ergebnis.verb_liter05 = Math.Floor(ergebnis.rest_liter / 0.5);
                    ergebnis.verb_liter0375 = Math.Floor(ergebnis.rest_liter / 0.375);

                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Basis(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);
            }*/



        }
    }
}


