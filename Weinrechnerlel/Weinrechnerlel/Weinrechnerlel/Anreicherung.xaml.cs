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
    public partial class Anreicherung : ContentPage
    {
        public Anreicherung()
        {
            //belegung der Auswahlboxen
            InitializeComponent();
            produktart.Items.Add("bitte auswählen");
            produktart.Items.Add("Most");
            produktart.Items.Add("Maische entrappt");
            produktart.Items.Add("Maische nicht entrappt");
            produktart.Items.Add("Wein");
            produktart.SelectedIndex = 0;

            mostgewicht.Items.Add("bitte auswählen");
            mostgewicht.Items.Add("44");
            mostgewicht.Items.Add("45");
            mostgewicht.Items.Add("46");
            mostgewicht.Items.Add("47");
            mostgewicht.Items.Add("48");
            mostgewicht.Items.Add("49");
            mostgewicht.Items.Add("50");
            mostgewicht.Items.Add("51");
            mostgewicht.Items.Add("52");
            mostgewicht.Items.Add("53");
            mostgewicht.Items.Add("54");
            mostgewicht.Items.Add("55");
            mostgewicht.Items.Add("56");
            mostgewicht.Items.Add("57");
            mostgewicht.Items.Add("58");
            mostgewicht.Items.Add("59");
            mostgewicht.Items.Add("60");
            mostgewicht.Items.Add("61");
            mostgewicht.Items.Add("62");
            mostgewicht.Items.Add("63");
            mostgewicht.Items.Add("64");
            mostgewicht.Items.Add("65");
            mostgewicht.Items.Add("66");
            mostgewicht.Items.Add("67");
            mostgewicht.Items.Add("68");
            mostgewicht.Items.Add("69");
            mostgewicht.Items.Add("70");
            mostgewicht.Items.Add("71");
            mostgewicht.Items.Add("72");
            mostgewicht.Items.Add("73");
            mostgewicht.Items.Add("74");
            mostgewicht.Items.Add("75");
            mostgewicht.Items.Add("76");
            mostgewicht.Items.Add("77");
            mostgewicht.Items.Add("78");
            mostgewicht.Items.Add("79");
            mostgewicht.Items.Add("80");
            mostgewicht.Items.Add("81");
            mostgewicht.Items.Add("82");
            mostgewicht.Items.Add("83");
            mostgewicht.Items.Add("84");
            mostgewicht.Items.Add("85");
            mostgewicht.Items.Add("86");
            mostgewicht.Items.Add("87");
            mostgewicht.Items.Add("88");
            mostgewicht.Items.Add("89");
            mostgewicht.Items.Add("90");
            mostgewicht.Items.Add("91");
            mostgewicht.Items.Add("92");
            mostgewicht.Items.Add("93");
            mostgewicht.Items.Add("94");
            mostgewicht.Items.Add("95");
            mostgewicht.Items.Add("96");
            mostgewicht.Items.Add("97");
            mostgewicht.Items.Add("98");
            mostgewicht.Items.Add("99");
            mostgewicht.Items.Add("100");
            mostgewicht.SelectedIndex = 0;

            anreicherungsspanne.Items.Add("bitte auswählen");
            anreicherungsspanne.Items.Add("1");
            anreicherungsspanne.Items.Add("2");
            anreicherungsspanne.Items.Add("3");
            anreicherungsspanne.Items.Add("4");
            anreicherungsspanne.Items.Add("5");
            anreicherungsspanne.Items.Add("6");
            anreicherungsspanne.Items.Add("7");
            anreicherungsspanne.Items.Add("8");
            anreicherungsspanne.Items.Add("9");
            anreicherungsspanne.Items.Add("10");
            anreicherungsspanne.Items.Add("11");
            anreicherungsspanne.Items.Add("12");
            anreicherungsspanne.Items.Add("13");
            anreicherungsspanne.Items.Add("14");
            anreicherungsspanne.Items.Add("15");
            anreicherungsspanne.Items.Add("16");
            anreicherungsspanne.Items.Add("17");
            anreicherungsspanne.Items.Add("18");
            anreicherungsspanne.Items.Add("19");
            anreicherungsspanne.Items.Add("20");
            anreicherungsspanne.Items.Add("21");
            anreicherungsspanne.Items.Add("22");
            anreicherungsspanne.Items.Add("23");
            anreicherungsspanne.Items.Add("24");
            anreicherungsspanne.Items.Add("25");
            anreicherungsspanne.Items.Add("26");
            anreicherungsspanne.Items.Add("27");
            anreicherungsspanne.Items.Add("28");
            anreicherungsspanne.Items.Add("29");
            anreicherungsspanne.Items.Add("30");
            anreicherungsspanne.Items.Add("31");
            anreicherungsspanne.Items.Add("32");
            anreicherungsspanne.Items.Add("33");
            anreicherungsspanne.Items.Add("34");
            anreicherungsspanne.Items.Add("35");
            anreicherungsspanne.Items.Add("36");
            anreicherungsspanne.SelectedIndex = 0;
        }
       // private double pa_zahl;

        Ergebnis_anreich ergebnis = new Ergebnis_anreich() { };

        string prodart;
        string mostgew;
        string anreichspann;
        string err;

        private void Produktart_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodart = produktart.Items[produktart.SelectedIndex];
        }

        private void Mostgewicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostgew = mostgewicht.Items[mostgewicht.SelectedIndex];
        }

        private void Anreicherungsspanne_SelectedIndexChanged(object sender, EventArgs e)
        {
            anreichspann = anreicherungsspanne.Items[anreicherungsspanne.SelectedIndex];
        }


        async void berechnen_Anreich(object sender, EventArgs e)
        {
            if (!this.IsBusy)
            {

                try
                {
                    //Ladebalken
                    this.IsBusy = true;
                    berechnen_anreich.IsVisible = false;

                    await Task.Run(() =>
                    {
                        //validierungen

                        if (maisch_menge.Text == "" || mostgew == "bitte auswählen" || anreichspann == "bitte auswählen" || maisch_menge.Text == null || prodart == "bitte auswählen")
                        {
                            err = "bitte füllen Sie alle Felder aus";
                            return;
                        }

                        double eingabe_user_maisch_menge;
                        try
                        {
                            eingabe_user_maisch_menge = Convert.ToDouble(maisch_menge.Text);
                        }
                        catch
                        {
                            err = "Es sind Zahlen einzugeben";
                            return;
                        }
                        if (eingabe_user_maisch_menge < 0)
                        {
                            err = "Ihre Eingabe muss positiv sein";
                            return;
                        }
                        //restaufruf
                        request_anreich param = new request_anreich() { mg = mostgew, asp = anreichspann, pa = prodart, maisch_menge = maisch_menge.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();

                        String answer;

                        String adress = "http://10.141.69.156:4438/api/Anreicherungs";
                        //timeout?
                        answer = rconn.HTTP_POST(adress, request, 50, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {
                            err= "Keine Verbindung zum Server";
                            //LOKALE BERECHNUNG !
                            //double eingabe_user_maisch_menge;
                            //try
                            //{
                            //    eingabe_user_maisch_menge = Convert.ToDouble(maisch_menge.Text);
                            //}
                            //catch
                            //{
                            //   err = "Es sind Zahlen einzugeben";
                            //    return;
                            //}
                            //if (eingabe_user_maisch_menge < 0)
                            //{
                            //    err = "Ihre Eingabe muss positiv sein";
                            //    return;
                            //}

                            //double mg1 = Convert.ToDouble(mostgew);
                            //switch (mg1)
                            //{
                            //    case 44:
                            //        mg1 = 39.5;
                            //        break;
                            //    case 45:
                            //        mg1 = 41.0;
                            //        break;
                            //    case 46:
                            //        mg1 = 41.8;
                            //        break;
                            //    case 47:
                            //        mg1 = 43.4;
                            //        break;
                            //    case 48:
                            //        mg1 = 44.2;
                            //        break;
                            //    case 49:
                            //        mg1 = 45.8;
                            //        break;
                            //    case 50:
                            //        mg1 = 46.6;
                            //        break;
                            //    case 51:
                            //        mg1 = 48.1;
                            //        break;
                            //    case 52:
                            //        mg1 = 49.7;
                            //        break;
                            //    case 53:
                            //        mg1 = 50.5;
                            //        break;
                            //    case 54:
                            //        mg1 = 52.1;
                            //        break;
                            //    case 55:
                            //        mg1 = 52.9;
                            //        break;
                            //    case 56:
                            //        mg1 = 54.4;
                            //        break;
                            //    case 57:
                            //        mg1 = 55.2;
                            //        break;
                            //    case 58:
                            //        mg1 = 56.8;
                            //        break;
                            //    case 59:
                            //        mg1 = 57.6;
                            //        break;
                            //    case 60:
                            //        mg1 = 59.2;
                            //        break;
                            //    case 61:
                            //        mg1 = 60.8;
                            //        break;
                            //    case 62:
                            //        mg1 = 61.6;
                            //        break;
                            //    case 63:
                            //        mg1 = 63.1;
                            //        break;
                            //    case 64:
                            //        mg1 = 63.9;
                            //        break;
                            //    case 65:
                            //        mg1 = 65.5;
                            //        break;
                            //    case 66:
                            //        mg1 = 66.3;
                            //        break;
                            //    case 67:
                            //        mg1 = 67.9;
                            //        break;
                            //    case 68:
                            //        mg1 = 69.5;
                            //        break;
                            //    case 69:
                            //        mg1 = 70.2;
                            //        break;
                            //    case 70:
                            //        mg1 = 71.9;
                            //        break;
                            //    case 71:
                            //        mg1 = 72.6;
                            //        break;
                            //    case 72:
                            //        mg1 = 74.2;
                            //        break;
                            //    case 73:
                            //        mg1 = 75.0;
                            //        break;
                            //    case 74:
                            //        mg1 = 76.6;
                            //        break;
                            //    case 75:
                            //        mg1 = 77.4;
                            //        break;
                            //    case 76:
                            //        mg1 = 78.9;
                            //        break;
                            //    case 77:
                            //        mg1 = 80.9;
                            //        break;
                            //    case 78:
                            //        mg1 = 81.3;
                            //        break;
                            //    case 79:
                            //        mg1 = 82.9;
                            //        break;
                            //    case 80:
                            //        mg1 = 83.7;
                            //        break;
                            //    case 81:
                            //        mg1 = 85.2;
                            //        break;
                            //    case 82:
                            //        mg1 = 86.1;
                            //        break;
                            //    case 83:
                            //        mg1 = 87.6;
                            //        break;
                            //    case 84:
                            //        mg1 = 89.2;
                            //        break;
                            //    case 85:
                            //        mg1 = 90.0;
                            //        break;
                            //    case 86:
                            //        mg1 = 91.6;
                            //        break;
                            //    case 87:
                            //        mg1 = 92.4;
                            //        break;
                            //    case 88:
                            //        mg1 = 93.9;
                            //        break;
                            //    case 89:
                            //        mg1 = 94.7;
                            //        break;
                            //    case 90:
                            //        mg1 = 96.3;
                            //        break;
                            //    case 91:
                            //        mg1 = 97.9;
                            //        break;
                            //    case 92:
                            //        mg1 = 98.7;
                            //        break;
                            //    case 93:
                            //        mg1 = 100.2;
                            //        break;
                            //    case 94:
                            //        mg1 = 101.1;
                            //        break;
                            //    case 95:
                            //        mg1 = 102.6;
                            //        break;
                            //    case 96:
                            //        mg1 = 103.4;
                            //        break;
                            //    case 97:
                            //        mg1 = 105.0;
                            //        break;
                            //    case 98:
                            //        mg1 = 105.8;
                            //        break;
                            //    case 99:
                            //        mg1 = 107.4;
                            //        break;
                            //    case 100:
                            //        mg1 = 108.9;
                            //        break;
                            //}

                            //switch (prodart)
                            //{
                            //    case "Most":
                            //        pa_zahl = 2.4;
                            //        break;
                            //    case "Maische entrappt":
                            //        pa_zahl = 2.125;
                            //        break;
                            //    case "Maische nicht entrappt":
                            //        pa_zahl = 2;
                            //        break;
                            //    case "Wein":
                            //        pa_zahl = 2.15;
                            //        break;

                            //}

                            ////Ergebnisse berechnnen
                            //double e1 = mg1;
                            //double e2 = Convert.ToDouble(anreichspann);
                            //double e3 = mg1 + Convert.ToDouble(anreichspann);
                            //string e4 = prodart;
                            //double e5 = pa_zahl * Convert.ToDouble(anreichspann) * 100 / 1000;
                            //double e6 = e5 * (Convert.ToDouble(maisch_menge.Text) / 100);
                            //double e7 = Math.Round(e6 * 0.6);
                            //int e7_int = (int)e7;
                            //double e8 = Math.Round(Convert.ToDouble(maisch_menge.Text) + e7);
                            //int e8_int = (int)e8;

                            //ergebnis.mg_e = e1;
                            //ergebnis.asp_e = e2;
                            //ergebnis.auf_alk = e3;
                            //ergebnis.pa_e = e4;
                            //ergebnis.sach = e5;
                            //ergebnis.sach_ges = e6;
                            //ergebnis.mehr_an = e7_int;
                            //ergebnis.menge_an = e8_int;
                        }
                        else
                        {
                            //auswerten wenn kein TImeout
                            AnreichRestResponse erg = new AnreichRestResponse() { };
                            erg = JsonConvert.DeserializeObject<AnreichRestResponse>(answer);
                            if (erg.EventStatus != 0)
                            {
                                err = erg.EventMessage;

                                return;
                            }
                            //Ergebnisse des Webservices zuweisen
                            ergebnis.mg_e = erg.mg_e;
                            ergebnis.asp_e = erg.asp_e;
                            ergebnis.auf_alk = erg.auf_alk;
                            ergebnis.pa_e = erg.pa_e;
                            ergebnis.sach = erg.sach;
                            ergebnis.sach_ges = erg.sach_ges;
                            ergebnis.mehr_an = erg.mehr_an;
                            ergebnis.menge_an = erg.menge_an;
                        }
                    });
                }
                // Ladebalken schließen
                finally
                {
                    this.IsBusy = false;
                    berechnen_anreich.IsVisible = true;
                    if (!string.IsNullOrEmpty(err))
                    {
                        await DisplayAlert("Hinweis", err, "OK");
                        err = null;
                    }//Push auf Ergebnisseite
                    else
                    {
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Anreich(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }
        }
    }
}



