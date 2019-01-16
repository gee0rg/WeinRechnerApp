using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;



namespace Weinrechnerlel
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Berechnung_gen_VS : ContentPage
    {


        string err;

        public Berechnung_gen_VS()
        {
            InitializeComponent();
            liter_gw = test.Text;
           
        }


        Ergebnis_gen_Vs ergebnis = new Ergebnis_gen_Vs() { };

        string liter_gw { get; set; }



        async void berechnung_gen(object sender, EventArgs e)
        {
            err = null;
            if (!this.IsBusy)
            {

                try
                {
                    //Ladebalken 
                    this.IsBusy = true;
                    berechnen.IsVisible = false;


                    await Task.Run(() =>
                    {
                        //Validierungen
                    double eingabe_user;
                    try
                    {
                        eingabe_user = Convert.ToDouble(test.Text);
                    }
                    catch
                    {
                        err = "Es sind Zahlen einzugeben";
                        return;
                    }
                    if (string.IsNullOrEmpty(test.Text))
                    {
                        err = "Es sind Zahlen einzugeben";
                        return;
                    }
                        if (eingabe_user < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }
                        //restaufruf
                        request_gen_VS param = new request_gen_VS() { liter_gw = test.Text };
                        string request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();
                        Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
                        string answer;
                        string adress = "http://10.141.69.156:4438/api/gen_Vs";
                        //string adress = "http://localhost:50088/api/aust_Vs";


                        answer = rconn.HTTP_POST(adress, request, 50);
                        //timeout ?
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {
                           err= "Keine Verbindung zum Server";
                            //LOKALE BERECHNUNG
                            //double eingabe_user;
                            //try
                            //{
                            //    eingabe_user = Convert.ToDouble(test.Text);
                            //}
                            //catch
                            //{
                            //    err = "Es sind Zahlen einzugeben";
                            //    return;
                            //}
                            //if (string.IsNullOrEmpty(test.Text))
                            //{
                            //    err = "Es sind Zahlen einzugeben";
                            //    return;
                            //}
                            //if (eingabe_user < 0)
                            //{
                            //    err = "Ihre Eingabe muss positiv sein";
                            //    return;
                            //}
                            ////1. Berechnung
                            //double a;
                            //a = Convert.ToDouble(test.Text) / 0.85 - Convert.ToDouble(eingabe_user);
                            //double b = Math.Floor(a);
                            //ergebnis.max_vw = Convert.ToInt32(a);

                            ////2. Berechnung
                            //double x;
                            //x = Convert.ToDouble(test.Text) / 0.75 - Convert.ToDouble(eingabe_user);
                            //x = Math.Floor(x);
                            //ergebnis.max_sr1 = Convert.ToInt32(x);

                            ////3. Berechnung
                            ////Ausgabe max_sr2
                            //double z;
                            //z = (Convert.ToDouble(test.Text) / 0.75) - (Convert.ToDouble(ergebnis.max_vw) + Convert.ToDouble(eingabe_user));
                            //z = Math.Floor(z);
                            //ergebnis.max_sr2 = Convert.ToInt32(z);
                            //ergebnis.max_vw1 = ergebnis.max_vw;
                        }
                        else
                        {
                            //auswerten wenn kein Timeout
                            genVSRestResponse erg = new genVSRestResponse() { };
                            erg = JsonConvert.DeserializeObject<genVSRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                err = erg.EventMessage;
                                return;
                            }
                            //ergebnisse des Webservices zuweisen
                            ergebnis.max_sr1 = erg.max_sr1;
                            ergebnis.max_sr2 = erg.max_sr2;
                            ergebnis.max_vw = erg.max_vw;
                            ergebnis.max_vw1 = erg.max_vw;
                        }
                    });

                }
                //Ladebalken schließen
                finally
                {
                    this.IsBusy = false;
                    berechnen.IsVisible = true;
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;

                    }
                    // Push auf Ergebnisseite
                    else
                    {
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Gen(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }


            }





        }


    }
}