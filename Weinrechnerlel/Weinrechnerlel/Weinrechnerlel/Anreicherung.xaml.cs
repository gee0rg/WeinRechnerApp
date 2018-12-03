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
            InitializeComponent();
        }
        private double pa_zahl;
        Ergebnis_anreich ergebnis = new Ergebnis_anreich() { };
        void berechnen_Anreich(object sender, EventArgs e)
        {

            request_anreich param = new request_anreich() { mg = mg.Text, asp = asp.Text, pa = pa.Text, maisch_menge = maisch_menge.Text };
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();
            Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
            String answer;
            String adress = "http://localhost:50088/api/basis_Vs";

            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                double mg1 = Convert.ToDouble(mg.Text);
                switch (mg1)
                {
                    case 44:
                        mg1 = 39.5;
                        break;
                    case 45:
                        mg1 = 41.0;
                        break;
                    case 46:
                        mg1 = 41.8;
                        break;
                    case 47:
                        mg1 = 43.4;
                        break;
                    case 48:
                        mg1 = 44.2;
                        break;
                    case 49:
                        mg1 = 45.8;
                        break;
                    case 50:
                        mg1 = 46.6;
                        break;
                    case 51:
                        mg1 = 48.1;
                        break;
                    case 52:
                        mg1 = 49.7;
                        break;
                    case 53:
                        mg1 = 50.5;
                        break;
                    case 54:
                        mg1 = 52.1;
                        break;
                    case 55:
                        mg1 = 52.9;
                        break;
                    case 56:
                        mg1 = 54.4;
                        break;
                    case 57:
                        mg1 = 55.2;
                        break;
                    case 58:
                        mg1 = 56.8;
                        break;
                    case 59:
                        mg1 = 57.6;
                        break;
                    case 60:
                        mg1 = 59.2;
                        break;
                    case 61:
                        mg1 = 60.8;
                        break;
                    case 62:
                        mg1 = 61.6;
                        break;
                    case 63:
                        mg1 = 63.1;
                        break;
                    case 64:
                        mg1 = 63.9;
                        break;
                    case 65:
                        mg1 = 65.5;
                        break;
                    case 66:
                        mg1 = 66.3;
                        break;
                    case 67:
                        mg1 = 67.9;
                        break;
                    case 68:
                        mg1 = 69.5;
                        break;
                    case 69:
                        mg1 = 70.2;
                        break;
                    case 70:
                        mg1 = 71.9;
                        break;
                    case 71:
                        mg1 = 72.6;
                        break;
                    case 72:
                        mg1 = 74.2;
                        break;
                    case 73:
                        mg1 = 75.0;
                        break;
                    case 74:
                        mg1 = 76.6;
                        break;
                    case 75:
                        mg1 = 77.4;
                        break;
                    case 76:
                        mg1 = 78.9;
                        break;
                    case 77:
                        mg1 = 80.9;
                        break;
                    case 78:
                        mg1 = 81.3;
                        break;
                    case 79:
                        mg1 = 82.9;
                        break;
                    case 80:
                        mg1 = 83.7;
                        break;
                    case 81:
                        mg1 = 85.2;
                        break;
                    case 82:
                        mg1 = 86.1;
                        break;
                    case 83:
                        mg1 = 87.6;
                        break;
                    case 84:
                        mg1 = 89.2;
                        break;
                    case 85:
                        mg1 = 90.0;
                        break;
                    case 86:
                        mg1 = 91.6;
                        break;
                    case 87:
                        mg1 = 92.4;
                        break;
                    case 88:
                        mg1 = 93.9;
                        break;
                    case 89:
                        mg1 = 94.7;
                        break;
                    case 90:
                        mg1 = 96.3;
                        break;
                    case 91:
                        mg1 = 97.9;
                        break;
                    case 92:
                        mg1 = 98.7;
                        break;
                    case 93:
                        mg1 = 100.2;
                        break;
                    case 94:
                        mg1 = 101.1;
                        break;
                    case 95:
                        mg1 = 102.6;
                        break;
                    case 96:
                        mg1 = 103.4;
                        break;
                    case 97:
                        mg1 = 105.0;
                        break;
                    case 98:
                        mg1 = 105.8;
                        break;
                    case 99:
                        mg1 = 107.4;
                        break;
                    case 100:
                        mg1 = 108.9;
                        break;

                }
                //hier muss ein Zugriff auf die Datenbank mit der entsprechenden Tabelle implementiert werden!
                // ComboBox

                String pa1 = Convert.ToString(pa.Text);
                
                switch (pa1)
                {
                    case "Most":
                        pa_zahl = 2.4;
                        break;
                    case "Maische entrappt":
                        pa_zahl = 2.125;
                        break;
                    case "Maische nicht entrappt":
                        pa_zahl = 2;
                        break;
                    case "Wein":
                        pa_zahl = 2.15;
                        break;
                }
                // ComboBox

                //Ergebnisse berechnnen
                double e1 = mg1;
                double e2 = Convert.ToDouble(asp.Text);
                double e3 = mg1 + Convert.ToDouble(asp.Text);
                string e4 = pa.Text;
                double e5 = pa_zahl * Convert.ToDouble(asp.Text) * 100 / 1000;
                double e6 = e5 * (Convert.ToDouble(maisch_menge.Text) / 100);
                double e7 = Math.Floor(e6 * 0.6); //Runden notwendig?
                double e8 = Math.Floor(Convert.ToDouble(maisch_menge.Text) + e7);  //Runden notwendig?

                ergebnis.mg_e = e1;
                ergebnis.asp_e = e2;
                ergebnis.auf_alk = e3;
                ergebnis.pa_e = e4;
                ergebnis.sach = e5;
                ergebnis.sach_ges = e6;
                ergebnis.mehr_an = e7;
                ergebnis.menge_an = e8;

            }


            else
            {
                AnreichRestResponse erg = new AnreichRestResponse() { };
                erg = JsonConvert.DeserializeObject<AnreichRestResponse>(answer);
                if (erg.EventStatus != 0)
                {
                    DisplayAlert("Hinweis", erg.EventMessage, "OK");

                    return;
                }
                ergebnis.mg_e = erg.mg_e;
                ergebnis.asp_e = erg.asp_e;
                ergebnis.auf_alk = erg.auf_alk;
                ergebnis.pa_e = erg.pa_e;
                ergebnis.sach = erg.sach;
                ergebnis.sach_ges = erg.sach_ges;
                ergebnis.mehr_an = erg.mehr_an;
                ergebnis.menge_an = erg.menge_an;

            }
                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Anreich(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);





            
        }
    }
}



           