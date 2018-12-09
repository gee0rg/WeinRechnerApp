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
        }
        double ag1 = 0;
        double zg1 = 0;
        Ergebnis_konz ergebnis = new Ergebnis_konz() { };
        void berechnen_Konz(object sender, EventArgs e)
        {

            request_konz param = new request_konz() { ag = ag.Text, zg = zg.Text, maisch_menge = maisch_menge.Text };
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();
            
            String answer;
            String adress = "http://localhost:50088/api/basis_Vs";

            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                double eingabe_user;
                try
                {
                    eingabe_user = Convert.ToDouble(ag.Text);
                    eingabe_user = Convert.ToDouble(zg.Text);
                    eingabe_user = Convert.ToDouble(maisch_menge.Text);
                }
                catch
                {
                    DisplayAlert("Hinweis", "Es sind Zahlen einzugeben", "OK");
                    return;
                }
                if (eingabe_user < 0)
                {
                    DisplayAlert("Hinweis", "Ihre Eingabe muss positiv sein", "OK");
                    return;
                }

                switch (Convert.ToInt32(ag.Text))
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
                    default:
                        DisplayAlert("Hinweis", "ungültiger Wert für das Ausgangsmostgewicht!", "OK");
                        break;

                }


                switch (Convert.ToInt32(zg.Text))
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
                    default:
                        DisplayAlert("Hinweis", "ungültiger Wert für das Zielmostgewicht!", "OK");
                        break;


                }
                //hier muss ein Zugriff auf die Datenbank mit der entsprechenden Tabelle implementiert werden!
                // ComboBox

                if (ag != null && zg != null && maisch_menge != null)
                {
                    if (Convert.ToInt32(ag.Text) > Convert.ToInt32(zg.Text))
                    {
                        DisplayAlert("Hinweis", "Zielmostgewicht niedriger als Ausgangsmostgewicht!", "OK");
                    }

                    else if ((zg1 - ag1) > 16)
                    {
                        DisplayAlert("Hinweis", "Anreicherungsspanne von 16 g/l ist überschritten!", "OK");

                        //Ergebnisse berechnnen
                        double e1 = ag1;
                        double e2 = zg1 - ag1;
                        double e3 = zg1;
                        double e4 = Math.Round((Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(zg.Text) - Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(ag.Text)) / Convert.ToDouble(zg.Text));// oder durch zg1 -> erfragen!
                        double e5 = Math.Round(Convert.ToDouble(maisch_menge.Text) - e4);

                        //Ausgabe Ergebnisse
                        ergebnis.mg_e = e1;
                        ergebnis.asp_e = e2;
                        ergebnis.auf_alk = e3;
                        int e4_int = (int)e4;
                        ergebnis.perm_entzug = e4_int;
                        int e5_int = (int)e5;
                        ergebnis.menge_konz = e5_int;

                    }
                    else // else-Berechnung ,macht keinen Sinn 
                    {
                        //Ergebnisse berechnnen
                        double e1 = ag1;
                        double e2 = zg1 - ag1;
                        double e3 = zg1;
                        double e4 = Math.Round((Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(zg.Text) - Convert.ToDouble(maisch_menge.Text) * Convert.ToDouble(ag.Text)) / Convert.ToDouble(zg.Text));// oder durch zg1 -> erfragen!
                        double e5 = Math.Round(Convert.ToDouble(maisch_menge.Text) - e4);

                        //Ausgabe Ergebnisse
                        ergebnis.mg_e = e1;

                        ergebnis.asp_e = e2;

                        ergebnis.auf_alk = e3;

                        int e4_int = (int)e4;
                        ergebnis.perm_entzug = e4_int;

                        int e5_int = (int)e5;
                        ergebnis.menge_konz = e5_int;
                    }
                }

                else
                {
                    KonzRestResponse erg = new KonzRestResponse() { };
                    erg = JsonConvert.DeserializeObject<KonzRestResponse>(answer);
                    if (erg.EventStatus != 0)
                    {
                        DisplayAlert("Hinweis", erg.EventMessage, "OK");

                        return;
                    }

                    ergebnis.mg_e = erg.mg_e;
                    ergebnis.asp_e = erg.asp_e;
                    ergebnis.auf_alk = erg.auf_alk;
                    ergebnis.perm_entzug = erg.perm_entzug;
                    ergebnis.menge_konz = erg.menge_konz;


                }
                    NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Konz(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                    Navigation.PushAsync(nav);


            }



        }
    }
}




           