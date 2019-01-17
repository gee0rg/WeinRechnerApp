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
    public partial class Entsäuerung : ContentPage
    {
        public Entsäuerung()
        {
            InitializeComponent();
           // Comboboxen belgen
            gesamtsäure_von.Items.Add("bitte auswählen");
            gesamtsäure_von.Items.Add("5,2");
            gesamtsäure_von.Items.Add("5,4");
            gesamtsäure_von.Items.Add("5,6");
            gesamtsäure_von.Items.Add("5,8");
            gesamtsäure_von.Items.Add("6,0");
            gesamtsäure_von.Items.Add("6,2");
            gesamtsäure_von.Items.Add("6,4");
            gesamtsäure_von.Items.Add("6,8");
            gesamtsäure_von.Items.Add("7,0");
            gesamtsäure_von.Items.Add("7,2");
            gesamtsäure_von.Items.Add("7,4");
            gesamtsäure_von.Items.Add("7,8");
            gesamtsäure_von.Items.Add("8,0");
            gesamtsäure_von.Items.Add("8,2");
            gesamtsäure_von.Items.Add("8,4");
            gesamtsäure_von.Items.Add("8,8");
            gesamtsäure_von.Items.Add("9,0");
            gesamtsäure_von.Items.Add("9,2");
            gesamtsäure_von.Items.Add("9,4");
            gesamtsäure_von.Items.Add("9,8");
            gesamtsäure_von.Items.Add("10,0");
            gesamtsäure_von.Items.Add("10,2");
            gesamtsäure_von.Items.Add("10,4");
            gesamtsäure_von.Items.Add("10,8");
            gesamtsäure_von.Items.Add("11,0");
            gesamtsäure_von.Items.Add("11,2");
            gesamtsäure_von.Items.Add("11,4");
            gesamtsäure_von.Items.Add("11,8");
            gesamtsäure_von.Items.Add("12,0");
            gesamtsäure_von.Items.Add("12,2");
            gesamtsäure_von.Items.Add("12,4");
            gesamtsäure_von.Items.Add("12,8");
            gesamtsäure_von.Items.Add("13,0");
            gesamtsäure_von.Items.Add("13,2");
            gesamtsäure_von.Items.Add("13,4");
            gesamtsäure_von.Items.Add("13,8");
            gesamtsäure_von.Items.Add("14,0");
            gesamtsäure_von.Items.Add("14,2");
            gesamtsäure_von.Items.Add("14,4");
            gesamtsäure_von.Items.Add("14,8");
            gesamtsäure_von.Items.Add("15,0");
            gesamtsäure_von.Items.Add("15,2");
            gesamtsäure_von.Items.Add("15,4");
            gesamtsäure_von.Items.Add("15,8");
            gesamtsäure_von.Items.Add("16,0");
            gesamtsäure_von.Items.Add("16,2");
            gesamtsäure_von.Items.Add("16,4");
            gesamtsäure_von.Items.Add("16,8");
            gesamtsäure_von.Items.Add("17,0");
            gesamtsäure_von.Items.Add("17,2");
            gesamtsäure_von.Items.Add("17,4");
            gesamtsäure_von.Items.Add("17,8");
            gesamtsäure_von.Items.Add("18,0");
            gesamtsäure_von.Items.Add("18,2");
            gesamtsäure_von.Items.Add("18,4");
            gesamtsäure_von.Items.Add("18,8");
            gesamtsäure_von.Items.Add("19,0");
            gesamtsäure_von.SelectedIndex = 0;

            gesamtsäure_auf.Items.Add("bitte auswählen");
            gesamtsäure_auf.Items.Add("5,2");
            gesamtsäure_auf.Items.Add("5,4");
            gesamtsäure_auf.Items.Add("5,6");
            gesamtsäure_auf.Items.Add("5,8");
            gesamtsäure_auf.Items.Add("6,0");
            gesamtsäure_auf.Items.Add("6,2");
            gesamtsäure_auf.Items.Add("6,4");
            gesamtsäure_auf.Items.Add("6,8");
            gesamtsäure_auf.Items.Add("7,0");
            gesamtsäure_auf.Items.Add("7,2");
            gesamtsäure_auf.Items.Add("7,4");
            gesamtsäure_auf.Items.Add("7,8");
            gesamtsäure_auf.Items.Add("8,0");
            gesamtsäure_auf.Items.Add("8,2");
            gesamtsäure_auf.Items.Add("8,4");
            gesamtsäure_auf.Items.Add("8,8");
            gesamtsäure_auf.Items.Add("9,0");
            gesamtsäure_auf.Items.Add("9,2");
            gesamtsäure_auf.Items.Add("9,4");
            gesamtsäure_auf.Items.Add("9,8");
            gesamtsäure_auf.Items.Add("10,0");
            gesamtsäure_auf.Items.Add("10,2");
            gesamtsäure_auf.Items.Add("10,4");
            gesamtsäure_auf.Items.Add("10,8");
            gesamtsäure_auf.Items.Add("11,0");
            gesamtsäure_auf.Items.Add("11,2");
            gesamtsäure_auf.Items.Add("11,4");
            gesamtsäure_auf.Items.Add("11,8");
            gesamtsäure_auf.Items.Add("12,0");
            gesamtsäure_auf.Items.Add("12,2");
            gesamtsäure_auf.Items.Add("12,4");
            gesamtsäure_auf.Items.Add("12,8");
            gesamtsäure_auf.Items.Add("13,0");
            gesamtsäure_auf.Items.Add("13,2");
            gesamtsäure_auf.Items.Add("13,4");
            gesamtsäure_auf.Items.Add("13,8");
            gesamtsäure_auf.Items.Add("14,0");
            gesamtsäure_auf.Items.Add("14,2");
            gesamtsäure_auf.Items.Add("14,4");
            gesamtsäure_auf.Items.Add("14,8");
            gesamtsäure_auf.Items.Add("15,0");
            gesamtsäure_auf.Items.Add("15,2");
            gesamtsäure_auf.Items.Add("15,4");
            gesamtsäure_auf.Items.Add("15,8");
            gesamtsäure_auf.Items.Add("16,0");
            gesamtsäure_auf.Items.Add("16,2");
            gesamtsäure_auf.Items.Add("16,4");
            gesamtsäure_auf.Items.Add("16,8");
            gesamtsäure_auf.Items.Add("17,0");
            gesamtsäure_auf.Items.Add("17,2");
            gesamtsäure_auf.Items.Add("17,4");
            gesamtsäure_auf.Items.Add("17,8");
            gesamtsäure_auf.Items.Add("18,0");
            gesamtsäure_auf.Items.Add("18,2");
            gesamtsäure_auf.Items.Add("18,4");
            gesamtsäure_auf.Items.Add("18,8");
            gesamtsäure_auf.Items.Add("19,0");
            gesamtsäure_auf.Items.Add("19,2");
            gesamtsäure_auf.Items.Add("19,4");
            gesamtsäure_auf.Items.Add("19,8");
            gesamtsäure_auf.Items.Add("20,0");
            gesamtsäure_auf.SelectedIndex = 0;

            gesamtsäure_in.Items.Add("bitte auswählen");
            gesamtsäure_in.Items.Add("5,2");
            gesamtsäure_in.Items.Add("5,4");
            gesamtsäure_in.Items.Add("5,6");
            gesamtsäure_in.Items.Add("5,8");
            gesamtsäure_in.Items.Add("6,0");
            gesamtsäure_in.Items.Add("6,2");
            gesamtsäure_in.Items.Add("6,4");
            gesamtsäure_in.Items.Add("6,8");
            gesamtsäure_in.Items.Add("7,0");
            gesamtsäure_in.Items.Add("7,2");
            gesamtsäure_in.Items.Add("7,4");
            gesamtsäure_in.Items.Add("7,8");
            gesamtsäure_in.Items.Add("8,0");
            gesamtsäure_in.Items.Add("8,2");
            gesamtsäure_in.Items.Add("8,4");
            gesamtsäure_in.Items.Add("8,8");
            gesamtsäure_in.Items.Add("9,0");
            gesamtsäure_in.Items.Add("9,2");
            gesamtsäure_in.Items.Add("9,4");
            gesamtsäure_in.Items.Add("9,8");
            gesamtsäure_in.Items.Add("10,0");
            gesamtsäure_in.Items.Add("10,2");
            gesamtsäure_in.Items.Add("10,4");
            gesamtsäure_in.Items.Add("10,8");
            gesamtsäure_in.Items.Add("11,0");
            gesamtsäure_in.Items.Add("11,2");
            gesamtsäure_in.Items.Add("11,4");
            gesamtsäure_in.Items.Add("11,8");
            gesamtsäure_in.Items.Add("12,0");
            gesamtsäure_in.Items.Add("12,2");
            gesamtsäure_in.Items.Add("12,4");
            gesamtsäure_in.Items.Add("12,8");
            gesamtsäure_in.Items.Add("13,0");
            gesamtsäure_in.Items.Add("13,2");
            gesamtsäure_in.Items.Add("13,4");
            gesamtsäure_in.Items.Add("13,8");
            gesamtsäure_in.Items.Add("14,0");
            gesamtsäure_in.Items.Add("14,2");
            gesamtsäure_in.Items.Add("14,4");
            gesamtsäure_in.Items.Add("14,8");
            gesamtsäure_in.Items.Add("15,0");
            gesamtsäure_in.Items.Add("15,2");
            gesamtsäure_in.Items.Add("15,4");
            gesamtsäure_in.Items.Add("15,8");
            gesamtsäure_in.Items.Add("16,0");
            gesamtsäure_in.Items.Add("16,2");
            gesamtsäure_in.Items.Add("16,4");
            gesamtsäure_in.Items.Add("16,8");
            gesamtsäure_in.Items.Add("17,0");
            gesamtsäure_in.Items.Add("17,2");
            gesamtsäure_in.Items.Add("17,4");
            gesamtsäure_in.Items.Add("17,8");
            gesamtsäure_in.Items.Add("18,0");
            gesamtsäure_in.Items.Add("18,2");
            gesamtsäure_in.Items.Add("18,4");
            gesamtsäure_in.Items.Add("18,8");
            gesamtsäure_in.Items.Add("19,0");
            gesamtsäure_in.SelectedIndex = 0;

            weinsäure.Items.Add("bitte auswählen");
            weinsäure.Items.Add("1,0");
            weinsäure.Items.Add("1,1");
            weinsäure.Items.Add("1,2");
            weinsäure.Items.Add("1,3");
            weinsäure.Items.Add("1,4");
            weinsäure.Items.Add("1,5");
            weinsäure.Items.Add("1,6");
            weinsäure.Items.Add("1,7");
            weinsäure.Items.Add("1,8");
            weinsäure.Items.Add("1,9");
            weinsäure.Items.Add("2,0");
            weinsäure.Items.Add("2,1");
            weinsäure.Items.Add("2,2");
            weinsäure.Items.Add("2,3");
            weinsäure.Items.Add("2,4");
            weinsäure.Items.Add("2,5");
            weinsäure.Items.Add("2,6");
            weinsäure.Items.Add("2,7");
            weinsäure.Items.Add("2,8");
            weinsäure.Items.Add("2,9");
            weinsäure.Items.Add("3,0");
            weinsäure.Items.Add("3,1");
            weinsäure.Items.Add("3,2");
            weinsäure.Items.Add("3,3");
            weinsäure.Items.Add("3,4");
            weinsäure.Items.Add("3,5");
            weinsäure.Items.Add("3,6");
            weinsäure.Items.Add("3,7");
            weinsäure.Items.Add("3,8");
            weinsäure.Items.Add("3,9");
            weinsäure.Items.Add("4,0");
            weinsäure.Items.Add("4,1");
            weinsäure.Items.Add("4,2");
            weinsäure.Items.Add("4,3");
            weinsäure.Items.Add("4,4");
            weinsäure.Items.Add("4,5");
            weinsäure.Items.Add("4,6");
            weinsäure.Items.Add("4,7");
            weinsäure.Items.Add("4,8");
            weinsäure.Items.Add("4,9");
            weinsäure.Items.Add("5,0");
            weinsäure.Items.Add("5,1");
            weinsäure.Items.Add("5,2");
            weinsäure.Items.Add("5,3");
            weinsäure.Items.Add("5,4");
            weinsäure.Items.Add("5,5");
            weinsäure.Items.Add("5,6");
            weinsäure.Items.Add("5,7");
            weinsäure.Items.Add("5,8");
            weinsäure.Items.Add("5,9");
            weinsäure.Items.Add("6,0");
            weinsäure.Items.Add("6,1");
            weinsäure.Items.Add("6,2");
            weinsäure.Items.Add("6,3");
            weinsäure.Items.Add("6,4");
            weinsäure.Items.Add("6,5");
            weinsäure.Items.Add("6,6");
            weinsäure.Items.Add("6,7");
            weinsäure.Items.Add("6,8");
            weinsäure.Items.Add("6,9");
            weinsäure.Items.Add("7,0");
            weinsäure.Items.Add("7,1");
            weinsäure.Items.Add("7,2");
            weinsäure.Items.Add("7,3");
            weinsäure.Items.Add("7,4");
            weinsäure.Items.Add("7,5");
            weinsäure.Items.Add("7,6");
            weinsäure.Items.Add("7,7");
            weinsäure.Items.Add("7,8");
            weinsäure.Items.Add("7,9");
            weinsäure.Items.Add("8,0");
            weinsäure.Items.Add("8,1");
            weinsäure.Items.Add("8,2");
            weinsäure.Items.Add("8,3");
            weinsäure.Items.Add("8,4");
            weinsäure.Items.Add("8,5");
            weinsäure.Items.Add("8,6");
            weinsäure.Items.Add("8,7");
            weinsäure.Items.Add("8,8");
            weinsäure.Items.Add("8,9");
            weinsäure.Items.Add("9,0");
            weinsäure.Items.Add("9,1");
            weinsäure.Items.Add("9,2");
            weinsäure.Items.Add("9,3");
            weinsäure.Items.Add("9,4");
            weinsäure.Items.Add("9,5");
            weinsäure.Items.Add("9,6");
            weinsäure.Items.Add("9,7");
            weinsäure.Items.Add("9,8");
            weinsäure.Items.Add("9,9");
            weinsäure.Items.Add("10,0");
            weinsäure.SelectedIndex = 0;
        }
        string gs_von_1;

        private void Gesamtsäure_von_SelectedIndexChanged(object sender, EventArgs e)
        {
            gs_von_1 = gesamtsäure_von.Items[gesamtsäure_von.SelectedIndex];
        }
        string gs_auf_1;

        private void Gesamtsäure_auf_SelectedIndexChanged(object sender, EventArgs e)
        {
            gs_auf_1 = gesamtsäure_auf.Items[gesamtsäure_auf.SelectedIndex];
            
        }

        string gs2_1;
        string ws_1;
        private void Gesamtsäure_in_SelectedIndexChanged(object sender, EventArgs e)
        {
            gs2_1 = gesamtsäure_in.Items[gesamtsäure_in.SelectedIndex];
            


            if (weinsäure.SelectedIndex == 0 || ws_1 == null)
            {
                return;
            }
            else
            {
                change_ent_spanne();
            }
        }

        private void change_ent_spanne()
        {
            bool validationvariableA=true;
            bool validationvariableB=true;
            if (gs2_1 == "bitte auswählen")
            {
                validationvariableA = false;
            }
            if (ws_1 == "bitte auswählen")
            {
                validationvariableB = false;
            }
            if(validationvariableA==true && validationvariableB == true) { 

                double gs2_1d = Convert.ToDouble(gs2_1, new System.Globalization.CultureInfo("de-DE"));


                double ws_1d = Convert.ToDouble(ws_1, new System.Globalization.CultureInfo("de-DE"));

                double e3 = Math.Round(gs2_1d * (ws_1d - 0.5) / (gs2_1d - ws_1d), 1);
                ent_spanne.Text = Convert.ToString(e3);
            }
            else
            {
                ent_spanne.Text = "";
            }


            //ergebnisse berechnen
      
            

        }

        private void Weinsäure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ws_1 = weinsäure.Items[weinsäure.SelectedIndex];

            if (gesamtsäure_in.SelectedIndex == 0 || gs2_1 == null )
            {
                return;
            }
            else
            {
                change_ent_spanne();
            }
        }
        Ergebnis_entsäu ergebnis = new Ergebnis_entsäu();

        async void berechnen_Entsäu1(object sender, EventArgs e)
        {
            //Ladebalken aktiviern
            string err = null;
            if (!this.IsBusy)
            {
                try
                {
                    this.IsBusy = true;
                    Entsäuerungteil1.IsVisible = false;
                    await Task.Run(() =>
                    {
                        //Validieren
                        if (em1.Text=="" || gs_von_1== "bitte auswählen" || gs_auf_1== "bitte auswählen" || em1.Text == null)
                        {
                            err = "bitte füllen Sie alle Felder aus";
                            return;
                        }
                        double eingabe_user_em1;
                        try
                        {
                            eingabe_user_em1 = Convert.ToDouble(em1.Text);

                        }
                        catch
                        {
                            err = "Es sind Zahlen einzugeben";
                            return;
                        }
                        if (eingabe_user_em1 < 0)
                        {
                        err = "Ihre Eingabe muss positiv sein";
                            return;
                        }

                        gs_von_1 = gs_von_1.Replace(',', '.');
                        double gs_von_1d = Convert.ToDouble(gs_von_1);


                        gs_auf_1 = gs_auf_1.Replace(',', '.');
                        double gs_auf_1d = Convert.ToDouble(gs_auf_1);
                        //Rest-Aufruf
                        request_entsäu param = new request_entsäu() { gs_von = gs_von_1, gs_auf = gs_auf_1, em1 = em1.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();

                        String answer;
                        String adress = "http://192.168.178.41:4438/api/Entsäuerungteil1";

                        answer = rconn.HTTP_POST(adress, request, 5, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {

                            err = "Keine Verbindung zum Server";



                            //Ergebnisse berechnnen
                            //double e1 = gs_von_1d - gs_auf_1d;
                            //double e2 = (Convert.ToDouble(em1.Text) / 100.0) * (67.0 / 1000.0) * e1;

                            ////Ausgabe Ergebnisse
                            //ergebnis.menge_ent1 = Math.Round(e2,3);
                            //ergebnis.um = e1;
                        }
                        else
                        {
                            EntsäuRestResponse erg = new EntsäuRestResponse() { };
                            erg = JsonConvert.DeserializeObject<EntsäuRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                err = erg.EventMessage;

                                return;
                            }
                            ergebnis.menge_ent1 = erg.menge_ent1;
                            ergebnis.um = erg.um;

                        }
                    });
                }
                finally
                {
                    //Ladenbalken schließen
                   this.IsBusy = false;
                    Entsäuerungteil1.IsVisible = true;
                    //Push auf Ergebnisseite
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;

                    }
                    // Push auf Ergebnisseite
                    else
                    {
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Entsäu(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }
        }
        //2. Berechnung
        async void berechnen_Entsäu2(object sender, EventArgs e)
        {
            string err = null;
            if (!this.IsBusy)
            {
                try
                {
                    this.IsBusy = true;
                    Entsäuerungteil2.IsVisible = false;
                    await Task.Run(() =>
                    {
                        //Validiern
                        if (em2.Text == "" || ent_um.Text=="" || ws_1 == "bitte auswählen" || gs2_1 == "bitte auswählen" || em2.Text == null || ent_um.Text == null)
                        {
                            err = "bitte füllen Sie alle Felder aus";
                            return;
                        }
                        if (em2.Text == "")
                        {
                            err = "bitte füllen sie alle Felder aus";
                        }
                        double eingabe_user_em2;
                        double eingabe_user_ent_um;
                        try
                        {
                            eingabe_user_ent_um = Convert.ToDouble(ent_um.Text);
                        }
                        catch
                        {
                            err = "Es sind Zahlen einzugeben";
                            return;
                        }
                        if (eingabe_user_ent_um < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }
                        try
                        {
                            eingabe_user_em2 = Convert.ToDouble(em2.Text);
                        }
                        catch
                        {
                            err = "Es sind Zahlen einzugeben";
                            return;
                        }
                        if (eingabe_user_em2 < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }

                        request_entsäu param = new request_entsäu() { gs2 = gs2_1, ws = ws_1, em2 = em2.Text, ent_um = ent_um.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();

                        String answer;
                        String adress = "http://192.168.178.41:4438/api/EntsäuerungsTeil2";

                        answer = rconn.HTTP_POST(adress, request, 5, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {

                            err = "Keine Verbindung zum Server";
                            //LOKALE BRECHNUNG
                            //gs2_1 = gs2_1.Replace(',', '.');
                            //double gs2_1d = Convert.ToDouble(gs2_1, new System.Globalization.CultureInfo("en-US"));



                            ////ergebnisse berechnen
                            //double test = Convert.ToDouble(ent_um.Text);
                            //double e4 = gs2_1d - test;                         //E5
                            //double e5 = ((gs2_1d - e4) * Convert.ToDouble(em2.Text) * 0.67) / 1000;     //E2
                            //double e6 = Convert.ToDouble(em2.Text) * ((gs2_1d - e4) / (gs2_1d - 2));    //E3
                            //double e7 = Convert.ToDouble(em2.Text) * ((gs2_1d - e4) / (gs2_1d - 3));    //E4

                            ////Ausgabe Ergebnisse

                            //ergebnis.menge_ent2 = e5;
                            //ergebnis.most_ent = Convert.ToInt32(e6);
                            //ergebnis.wein_ent = Convert.ToInt32(e7);
                            //ergebnis.auf = e4;

                        }
                        else
                        {
                            EntsäuRestResponse erg = new EntsäuRestResponse() { };
                            erg = JsonConvert.DeserializeObject<EntsäuRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                err = erg.EventMessage;

                                return;
                            }
                            //ergebisse des Webservices zuweisen
                            ergebnis.menge_ent2 = erg.menge_ent2;
                            ergebnis.most_ent = erg.most_ent;
                            ergebnis.wein_ent = erg.wein_ent;
                            ergebnis.auf = erg.auf;

                        }
                    });
                }
                finally {
                    //Ladenbalken schließen
                    this.IsBusy = false;
                    Entsäuerungteil2.IsVisible = true;
                    //Push auf Ergebnisseite
                    if (!string.IsNullOrEmpty(err))
                {
                    await DisplayAlert("Hinweis", err, "OK");
                    err = null;

                }
                // Push auf Ergebnisseite
                else
                {
                    NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Entsäu(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                    await Navigation.PushAsync(nav);
                }
                }
            }
        }

       
    }
}