using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Rechnungen
{
    public class Ergebnis_anreich
    {
        public double mg_e { get; set; }
        public double asp_e { get; set; }
        public double auf_alk { get; set; }
        public String pa_e { get; set; }
        public double sach { get; set; }
        public double sach_ges { get; set; }
        public double mehr_an { get; set; }
        public double menge_an { get; set; }

    }
    class Rechnung6_anreich
    {
        static void Main(string[] args)
        {
            Ergebnis_anreich ergebnis = new Ergebnis_anreich();

            Ergebnis_anreich anreicherung (double mg, int asp, String pa, double maisch_menge)
            {
                switch (mg)
                {
                    case 44: mg = 39.5;
                        break;
                    case 45: mg = 41.0;
                        break;
                    case 46: mg = 41.8;
                        break;
                    case 47: mg = 43.4;
                        break;
                    case 48: mg = 44.2;
                        break;
                    case 49: mg = 45.8;
                        break;
                    case 50: mg = 46.6;
                        break;
                    case 51: mg = 48.1;
                        break;
                    case 52: mg = 49.7;
                        break;
                    case 53: mg = 50.5;
                        break;
                    case 54: mg = 52.1;
                        break;
                    case 55: mg = 52.9;
                        break;
                    case 56: mg = 54.4;
                        break;
                    case 57: mg = 55.2;
                        break;
                    case 58: mg = 56.8;
                        break;
                    case 59: mg = 57.6;
                        break;
                    case 60: mg = 59.2;
                        break;
                    case 61: mg = 60.8;
                        break;
                    case 62: mg = 61.6;
                        break;
                    case 63: mg = 63.1;
                        break;
                    case 64: mg = 63.9;
                        break;
                    case 65: mg = 65.5;
                        break;
                    case 66: mg = 66.3;
                        break;
                    case 67: mg = 67.9;
                        break;
                    case 68: mg = 69.5;
                        break;
                    case 69: mg = 70.2;
                        break;
                    case 70: mg = 71.9;
                        break;
                    case 71: mg = 72.6;
                        break;
                    case 72: mg = 74.2;
                        break;
                    case 73: mg = 75.0;
                        break;
                    case 74: mg = 76.6;
                        break;
                    case 75: mg = 77.4;
                        break;
                    case 76: mg = 78.9;
                        break;
                    case 77: mg = 80.9;
                        break;
                    case 78: mg = 81.3;
                        break;
                    case 79: mg = 82.9;
                        break;
                    case 80: mg = 83.7;
                        break;
                    case 81: mg = 85.2;
                        break;
                    case 82: mg = 86.1;
                        break;
                    case 83: mg = 87.6;
                        break;
                    case 84: mg = 89.2;
                        break;
                    case 85: mg = 90.0;
                        break;
                    case 86: mg = 91.6;
                        break;
                    case 87: mg = 92.4;
                        break;
                    case 88: mg = 93.9;
                        break;
                    case 89: mg = 94.7;
                        break;
                    case 90: mg = 96.3;
                        break;
                    case 91: mg = 97.9;
                        break;
                    case 92: mg = 98.7;
                        break;
                    case 93: mg = 100.2;
                        break;
                    case 94: mg = 101.1;
                        break;
                    case 95: mg = 102.6;
                        break;
                    case 96: mg = 103.4;
                        break;
                    case 97: mg = 105.0;
                        break;
                    case 98: mg = 105.8;
                        break;
                    case 99: mg = 107.4;
                        break;
                    case 100: mg = 108.9;
                        break;
                    default: return null;
                }
                //hier muss ein Zugriff auf die Datenbank mit der entsprechenden Tabelle implementiert werden!
                double pa_zahl;
                switch (pa)
                {
                    case "Most":  pa_zahl = 2.4;
                        break;
                    case "Maische entrappt": pa_zahl = 2.125;
                        break;
                    case "Maische nicht entrappt": pa_zahl = 2;
                        break;
                    case "Wein": pa_zahl = 2.15;
                        break;
                    default: return null;
                }
                //Ergebnisse berechnnen
                double e1 = mg;
                double e2 = asp;
                double e3 = mg + asp;
                string e4 = pa;
                double e5 = pa_zahl * asp * 100 / 1000;
                double e6 = e5 * (maisch_menge / 100);
                double e7 = Math.Floor(e6 * 0.6); //Runden notwendig?
                double e8 = Math.Floor(maisch_menge + e7);  //Runden notwendig?

                //Ausgabe Ergebnisse
                ergebnis.mg_e = e1;
                Console.WriteLine(ergebnis.mg_e);
                ergebnis.asp_e = e2;
                Console.WriteLine(ergebnis.asp_e);
                ergebnis.auf_alk = e3;
                Console.WriteLine(ergebnis.auf_alk);
                ergebnis.pa_e = e4;
                Console.WriteLine(ergebnis.pa_e);
                ergebnis.sach = e5;
                Console.WriteLine(ergebnis.sach);
                ergebnis.sach_ges = e6;
                Console.WriteLine(ergebnis.sach_ges);
                ergebnis.mehr_an = e7;
                Console.WriteLine(ergebnis.mehr_an);
                ergebnis.menge_an = e8;
                Console.WriteLine(ergebnis.menge_an);

                return null;
            }

            Ergebnis_anreich test = new Ergebnis_anreich() { };
            test = anreicherung(44, 25, "Most", 100);


            Console.ReadKey();
        }



    }
}*/
