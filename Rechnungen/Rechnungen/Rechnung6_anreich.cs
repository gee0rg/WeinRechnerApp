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
