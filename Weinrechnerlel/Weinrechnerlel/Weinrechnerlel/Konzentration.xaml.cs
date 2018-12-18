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
    public partial class Konzentration : ContentPage
    {
        public Konzentration()
        {
            InitializeComponent();
            ausgangsmostgewicht.Items.Add("bitte auswählen");
            ausgangsmostgewicht.Items.Add("60");
            ausgangsmostgewicht.Items.Add("61");
            ausgangsmostgewicht.Items.Add("62");
            ausgangsmostgewicht.Items.Add("63");
            ausgangsmostgewicht.Items.Add("64");
            ausgangsmostgewicht.Items.Add("65");
            ausgangsmostgewicht.Items.Add("66");
            ausgangsmostgewicht.Items.Add("67");
            ausgangsmostgewicht.Items.Add("68");
            ausgangsmostgewicht.Items.Add("69");
            ausgangsmostgewicht.Items.Add("70");
            ausgangsmostgewicht.Items.Add("71");
            ausgangsmostgewicht.Items.Add("72");
            ausgangsmostgewicht.Items.Add("73");
            ausgangsmostgewicht.Items.Add("74");
            ausgangsmostgewicht.Items.Add("75");
            ausgangsmostgewicht.Items.Add("76");
            ausgangsmostgewicht.Items.Add("77");
            ausgangsmostgewicht.Items.Add("78");
            ausgangsmostgewicht.Items.Add("79");
            ausgangsmostgewicht.Items.Add("80");
            ausgangsmostgewicht.Items.Add("81");
            ausgangsmostgewicht.Items.Add("82");
            ausgangsmostgewicht.Items.Add("83");
            ausgangsmostgewicht.Items.Add("84");
            ausgangsmostgewicht.Items.Add("85");
            ausgangsmostgewicht.Items.Add("86");
            ausgangsmostgewicht.Items.Add("87");
            ausgangsmostgewicht.Items.Add("88");
            ausgangsmostgewicht.Items.Add("89");
            ausgangsmostgewicht.Items.Add("90");
            ausgangsmostgewicht.Items.Add("91");
            ausgangsmostgewicht.Items.Add("92");
            ausgangsmostgewicht.Items.Add("93");
            ausgangsmostgewicht.Items.Add("94");
            ausgangsmostgewicht.Items.Add("95");
            ausgangsmostgewicht.Items.Add("96");
            ausgangsmostgewicht.Items.Add("97");
            ausgangsmostgewicht.Items.Add("98");
            ausgangsmostgewicht.Items.Add("99");
            ausgangsmostgewicht.Items.Add("100");
            //ausgangsmostgewicht.Items.Add("101");
            //ausgangsmostgewicht.Items.Add("102");
            //ausgangsmostgewicht.Items.Add("103");
            //ausgangsmostgewicht.Items.Add("104");
            //ausgangsmostgewicht.Items.Add("105");
            //ausgangsmostgewicht.Items.Add("106");
            //ausgangsmostgewicht.Items.Add("107");
            //ausgangsmostgewicht.Items.Add("108");
            //ausgangsmostgewicht.Items.Add("109");
            //ausgangsmostgewicht.Items.Add("110");
            //ausgangsmostgewicht.Items.Add("111");
            //ausgangsmostgewicht.Items.Add("112");
            //ausgangsmostgewicht.Items.Add("113");
            //ausgangsmostgewicht.Items.Add("114");
            //ausgangsmostgewicht.Items.Add("115");
            //ausgangsmostgewicht.Items.Add("116");
            //ausgangsmostgewicht.Items.Add("117");
            //ausgangsmostgewicht.Items.Add("118");
            //ausgangsmostgewicht.Items.Add("119");
            //ausgangsmostgewicht.Items.Add("120");
            //ausgangsmostgewicht.Items.Add("121");
            //ausgangsmostgewicht.Items.Add("122");
            //ausgangsmostgewicht.Items.Add("123");
            //ausgangsmostgewicht.Items.Add("124");
            //ausgangsmostgewicht.Items.Add("125");
            //ausgangsmostgewicht.Items.Add("126");
            //ausgangsmostgewicht.Items.Add("127");
            //ausgangsmostgewicht.Items.Add("128");
            //ausgangsmostgewicht.Items.Add("129");
            //ausgangsmostgewicht.Items.Add("130");
            //ausgangsmostgewicht.Items.Add("131");
            //ausgangsmostgewicht.Items.Add("132");
            //ausgangsmostgewicht.Items.Add("133");
            //ausgangsmostgewicht.Items.Add("134");
            //ausgangsmostgewicht.Items.Add("135");
            //ausgangsmostgewicht.Items.Add("136");
            //ausgangsmostgewicht.Items.Add("137");
            //ausgangsmostgewicht.Items.Add("138");
            //ausgangsmostgewicht.Items.Add("139");
            //ausgangsmostgewicht.Items.Add("140");
            //ausgangsmostgewicht.Items.Add("141");
            //ausgangsmostgewicht.Items.Add("142");
            //ausgangsmostgewicht.Items.Add("143");
            //ausgangsmostgewicht.Items.Add("144");
            //ausgangsmostgewicht.Items.Add("145");
            //ausgangsmostgewicht.Items.Add("146");
            //ausgangsmostgewicht.Items.Add("147");
            //ausgangsmostgewicht.Items.Add("148");
            //ausgangsmostgewicht.Items.Add("149");
            //ausgangsmostgewicht.Items.Add("150");
            ausgangsmostgewicht.SelectedIndex = 0;

            zielmostgewicht.Items.Add("bitte auswählen");
            zielmostgewicht.Items.Add("60");
            zielmostgewicht.Items.Add("61");
            zielmostgewicht.Items.Add("62");
            zielmostgewicht.Items.Add("63");
            zielmostgewicht.Items.Add("64");
            zielmostgewicht.Items.Add("65");
            zielmostgewicht.Items.Add("66");
            zielmostgewicht.Items.Add("67");
            zielmostgewicht.Items.Add("68");
            zielmostgewicht.Items.Add("69");
            zielmostgewicht.Items.Add("70");
            zielmostgewicht.Items.Add("71");
            zielmostgewicht.Items.Add("72");
            zielmostgewicht.Items.Add("73");
            zielmostgewicht.Items.Add("74");
            zielmostgewicht.Items.Add("75");
            zielmostgewicht.Items.Add("76");
            zielmostgewicht.Items.Add("77");
            zielmostgewicht.Items.Add("78");
            zielmostgewicht.Items.Add("79");
            zielmostgewicht.Items.Add("80");
            zielmostgewicht.Items.Add("81");
            zielmostgewicht.Items.Add("82");
            zielmostgewicht.Items.Add("83");
            zielmostgewicht.Items.Add("84");
            zielmostgewicht.Items.Add("85");
            zielmostgewicht.Items.Add("86");
            zielmostgewicht.Items.Add("87");
            zielmostgewicht.Items.Add("88");
            zielmostgewicht.Items.Add("89");
            zielmostgewicht.Items.Add("90");
            zielmostgewicht.Items.Add("91");
            zielmostgewicht.Items.Add("92");
            zielmostgewicht.Items.Add("93");
            zielmostgewicht.Items.Add("94");
            zielmostgewicht.Items.Add("95");
            zielmostgewicht.Items.Add("96");
            zielmostgewicht.Items.Add("97");
            zielmostgewicht.Items.Add("98");
            zielmostgewicht.Items.Add("99");
            zielmostgewicht.Items.Add("100");
            //zielmostgewicht.Items.Add("101");
            //zielmostgewicht.Items.Add("102");
            //zielmostgewicht.Items.Add("103");
            //zielmostgewicht.Items.Add("104");
            //zielmostgewicht.Items.Add("105");
            //zielmostgewicht.Items.Add("106");
            //zielmostgewicht.Items.Add("107");
            //zielmostgewicht.Items.Add("108");
            //zielmostgewicht.Items.Add("109");
            //zielmostgewicht.Items.Add("110");
            //zielmostgewicht.Items.Add("111");
            //zielmostgewicht.Items.Add("112");
            //zielmostgewicht.Items.Add("113");
            //zielmostgewicht.Items.Add("114");
            //zielmostgewicht.Items.Add("115");
            //zielmostgewicht.Items.Add("116");
            //zielmostgewicht.Items.Add("117");
            //zielmostgewicht.Items.Add("118");
            //zielmostgewicht.Items.Add("119");
            //zielmostgewicht.Items.Add("120");
            //zielmostgewicht.Items.Add("121");
            //zielmostgewicht.Items.Add("122");
            //zielmostgewicht.Items.Add("123");
            //zielmostgewicht.Items.Add("124");
            //zielmostgewicht.Items.Add("125");
            //zielmostgewicht.Items.Add("126");
            //zielmostgewicht.Items.Add("127");
            //zielmostgewicht.Items.Add("128");
            //zielmostgewicht.Items.Add("129");
            //zielmostgewicht.Items.Add("130");
            //zielmostgewicht.Items.Add("131");
            //zielmostgewicht.Items.Add("132");
            //zielmostgewicht.Items.Add("133");
            //zielmostgewicht.Items.Add("134");
            //zielmostgewicht.Items.Add("135");
            //zielmostgewicht.Items.Add("136");
            //zielmostgewicht.Items.Add("137");
            //zielmostgewicht.Items.Add("138");
            //zielmostgewicht.Items.Add("139");
            //zielmostgewicht.Items.Add("140");
            //zielmostgewicht.Items.Add("141");
            //zielmostgewicht.Items.Add("142");
            //zielmostgewicht.Items.Add("143");
            //zielmostgewicht.Items.Add("144");
            //zielmostgewicht.Items.Add("145");
            //zielmostgewicht.Items.Add("146");
            //zielmostgewicht.Items.Add("147");
            //zielmostgewicht.Items.Add("148");
            //zielmostgewicht.Items.Add("149");
            //zielmostgewicht.Items.Add("150");
            zielmostgewicht.SelectedIndex = 0;

        }
        double ag1 = 0;
        double zg1 = 0;
        Ergebnis_konz ergebnis = new Ergebnis_konz() { };

        string ausgangsmostgew;
        string zielmostgew;
        string err;
        string alert;


        private void Ausgangsmostgewicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            ausgangsmostgew = ausgangsmostgewicht.Items[ausgangsmostgewicht.SelectedIndex];
        }

        private void Zielmostgewicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            zielmostgew = zielmostgewicht.Items[zielmostgewicht.SelectedIndex];
        }

        async void berechnen_Konz(object sender, EventArgs e)
        {
            if (!this.IsBusy)
            {

                try
                {
                    this.IsBusy = true;
                    berechnen_konz.IsVisible = false;

                    await Task.Run(() =>
                    {

                        request_konz param = new request_konz() { ag = ausgangsmostgew, zg = zielmostgew, maisch_menge = maisch_menge.Text };
                        String request = JsonConvert.SerializeObject(param);
                        RESTConnector rconn = new RESTConnector();

                        String answer;
                        String adress = "http://localhost:50088/api/basis_Vs";

                        answer = rconn.HTTP_POST(adress, request, 5, false);
                        if (answer.Contains("REST_HTTP_ERROR"))
                        {
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

                            switch (Convert.ToInt32(ausgangsmostgew))
                            {
                                case 60:
                                    ag1 = 59.2;
                                    break;
                                case 61:
                                    ag1 = 60.8;
                                    break;
                                case 62:
                                    ag1 = 61.6;
                                    break;
                                case 63:
                                    ag1 = 63.1;
                                    break;
                                case 64:
                                    ag1 = 63.9;
                                    break;
                                case 65:
                                    ag1 = 65.5;
                                    break;
                                case 66:
                                    ag1 = 66.3;
                                    break;
                                case 67:
                                    ag1 = 67.9;
                                    break;
                                case 68:
                                    ag1 = 69.5;
                                    break;
                                case 69:
                                    ag1 = 70.2;
                                    break;
                                case 70:
                                    ag1 = 71.9;
                                    break;
                                case 71:
                                    ag1 = 72.6;
                                    break;
                                case 72:
                                    ag1 = 74.2;
                                    break;
                                case 73:
                                    ag1 = 75.0;
                                    break;
                                case 74:
                                    ag1 = 76.6;
                                    break;
                                case 75:
                                    ag1 = 77.4;
                                    break;
                                case 76:
                                    ag1 = 78.9;
                                    break;
                                case 77:
                                    ag1 = 80.9;
                                    break;
                                case 78:
                                    ag1 = 81.3;
                                    break;
                                case 79:
                                    ag1 = 82.9;
                                    break;
                                case 80:
                                    ag1 = 83.7;
                                    break;
                                case 81:
                                    ag1 = 85.2;
                                    break;
                                case 82:
                                    ag1 = 86.1;
                                    break;
                                case 83:
                                    ag1 = 87.6;
                                    break;
                                case 84:
                                    ag1 = 89.2;
                                    break;
                                case 85:
                                    ag1 = 90.0;
                                    break;
                                case 86:
                                    ag1 = 91.6;
                                    break;
                                case 87:
                                    ag1 = 92.4;
                                    break;
                                case 88:
                                    ag1 = 93.9;
                                    break;
                                case 89:
                                    ag1 = 94.7;
                                    break;
                                case 90:
                                    ag1 = 96.3;
                                    break;
                                case 91:
                                    ag1 = 97.9;
                                    break;
                                case 92:
                                    ag1 = 98.7;
                                    break;
                                case 93:
                                    ag1 = 100.2;
                                    break;
                                case 94:
                                    ag1 = 101.1;
                                    break;
                                case 95:
                                    ag1 = 102.6;
                                    break;
                                case 96:
                                    ag1 = 103.4;
                                    break;
                                case 97:
                                    ag1 = 105.0;
                                    break;
                                case 98:
                                    ag1 = 105.8;
                                    break;
                                case 99:
                                    ag1 = 107.4;
                                    break;
                                case 100:
                                    ag1 = 108.9;
                                    break;
                            }


                            switch (Convert.ToInt32(zielmostgew))
                            {
                                case 60:
                                    zg1 = 59.2;
                                    break;
                                case 61:
                                    zg1 = 60.8;
                                    break;
                                case 62:
                                    zg1 = 61.6;
                                    break;
                                case 63:
                                    zg1 = 63.1;
                                    break;
                                case 64:
                                    zg1 = 63.9;
                                    break;
                                case 65:
                                    zg1 = 65.5;
                                    break;
                                case 66:
                                    zg1 = 66.3;
                                    break;
                                case 67:
                                    zg1 = 67.9;
                                    break;
                                case 68:
                                    zg1 = 69.5;
                                    break;
                                case 69:
                                    zg1 = 70.2;
                                    break;
                                case 70:
                                    zg1 = 71.9;
                                    break;
                                case 71:
                                    zg1 = 72.6;
                                    break;
                                case 72:
                                    zg1 = 74.2;
                                    break;
                                case 73:
                                    zg1 = 75.0;
                                    break;
                                case 74:
                                    zg1 = 76.6;
                                    break;
                                case 75:
                                    zg1 = 77.4;
                                    break;
                                case 76:
                                    zg1 = 78.9;
                                    break;
                                case 77:
                                    zg1 = 80.9;
                                    break;
                                case 78:
                                    zg1 = 81.3;
                                    break;
                                case 79:
                                    zg1 = 82.9;
                                    break;
                                case 80:
                                    zg1 = 83.7;
                                    break;
                                case 81:
                                    zg1 = 85.2;
                                    break;
                                case 82:
                                    zg1 = 86.1;
                                    break;
                                case 83:
                                    zg1 = 87.6;
                                    break;
                                case 84:
                                    zg1 = 89.2;
                                    break;
                                case 85:
                                    zg1 = 90.0;
                                    break;
                                case 86:
                                    zg1 = 91.6;
                                    break;
                                case 87:
                                    zg1 = 92.4;
                                    break;
                                case 88:
                                    zg1 = 93.9;
                                    break;
                                case 89:
                                    zg1 = 94.7;
                                    break;
                                case 90:
                                    zg1 = 96.3;
                                    break;
                                case 91:
                                    zg1 = 97.9;
                                    break;
                                case 92:
                                    zg1 = 98.7;
                                    break;
                                case 93:
                                    zg1 = 100.2;
                                    break;
                                case 94:
                                    zg1 = 101.1;
                                    break;
                                case 95:
                                    zg1 = 102.6;
                                    break;
                                case 96:
                                    zg1 = 103.4;
                                    break;
                                case 97:
                                    zg1 = 105.0;
                                    break;
                                case 98:
                                    zg1 = 105.8;
                                    break;
                                case 99:
                                    zg1 = 107.4;
                                    break;
                                case 100:
                                    zg1 = 108.9;
                                    break;

                            }
                            //hier muss ein Zugriff auf die Datenbank mit der entsprechenden Tabelle implementiert werden!
                            // ComboBox

                            if (ausgangsmostgew != null && zielmostgew != null && maisch_menge != null)
                            {
                                if (Convert.ToInt32(ausgangsmostgew) > Convert.ToInt32(zielmostgew))
                                {
                                    alert = "Zielmostgewicht niedriger als Ausgangsmostgewicht!";
                                }

                                else if ((zg1 - ag1) > 16)
                                {
                                    alert = "Anreicherungsspanne von 16 g/l ist überschritten!";

                                    //Ergebnisse berechnnen
                                    double e1 = ag1;
                                    double e2 = zg1 - ag1;
                                    double e3 = zg1;
                                    double e4 = Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(zielmostgew) - (Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(ausgangsmostgew));
                                    double e4_1 = Math.Round(e4 / Convert.ToDouble(zielmostgew));
                                    double e5 = Math.Round(Convert.ToDouble(maisch_menge.Text) - e4_1);

                                    //Ausgabe Ergebnisse
                                    ergebnis.mg_e = e1;
                                    ergebnis.asp_e = e2;
                                    ergebnis.auf_alk = e3;
                                    int e4_int = Convert.ToInt32(e4_1);
                                    ergebnis.perm_entzug = e4_int;
                                    int e5_int = Convert.ToInt32(e5);
                                    ergebnis.menge_konz = e5_int;

                                }
                                else // else-Berechnung ,macht keinen Sinn 
                                {
                                    //Ergebnisse berechnnen
                                    double e1 = ag1;
                                    double e2 = zg1 - ag1;
                                    double e3 = zg1;
                                    double e4 = Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(zielmostgew) - (Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(ausgangsmostgew));
                                    double e4_1 = Math.Round(e4 / Convert.ToDouble(zielmostgew));
                                    double e5 = Math.Round(Convert.ToDouble(maisch_menge.Text) - e4_1);

                                    //Ausgabe Ergebnisse
                                    ergebnis.mg_e = e1;

                                    ergebnis.asp_e = e2;

                                    ergebnis.auf_alk = e3;

                                    int e4_int = Convert.ToInt32(e4_1);
                                    ergebnis.perm_entzug = e4_int;

                                    int e5_int = Convert.ToInt32(e5);
                                    ergebnis.menge_konz = e5_int;
                                }
                            }

                            else
                            {
                                KonzRestResponse erg = new KonzRestResponse() { };
                                erg = JsonConvert.DeserializeObject<KonzRestResponse>(answer);
                                if (erg.EventStatus != 0)
                                {
                                    //Eventstatus auswerten und dann alert oder err belegen
                                    return;
                                }

                                ergebnis.mg_e = erg.mg_e;
                                ergebnis.asp_e = erg.asp_e;
                                ergebnis.auf_alk = erg.auf_alk;
                                ergebnis.perm_entzug = erg.perm_entzug;
                                ergebnis.menge_konz = erg.menge_konz;
                            }
                        }
                    });
                }
                finally
                {
                    this.IsBusy = false;
                    berechnen_konz.IsVisible = true;

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
                        NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Konz(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                        await Navigation.PushAsync(nav);
                    }
                }
            }
        }
    }
}




