using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungen
{
    public class Ergebnis_konz
    {
        public double mg_e { get; set; }
        public double asp_e { get; set; }
        public double auf_alk { get; set; }
        public int perm_entzug { get; set; }
        public int menge_konz { get; set; }

    }
    class Rechnung7_konz
    {
        static void Main(string[] args)
        {
            Ergebnis_konz ergebnis = new Ergebnis_konz();

            Ergebnis_konz konzentration(double ag, double zg, double maisch_menge)
            {
                double ag1;
                switch (ag)
                {
                    case 60:
                        ag1 = 59.2;
                        break;
                    case 65:
                        ag1 = 65.5;
                        break;
                    case 70:
                        ag1 = 71.9;
                        break;
                    case 150:
                        ag1 = 169.7;
                        break;
                    default: return null;
                }

                double zg1;
                switch (zg)
                {
                    case 60:
                        zg1 = 59.2;
                        break;
                    case 65:
                        zg1 = 65.5;
                        break;
                    case 70:
                        zg1 = 71.9;
                        break;
                    case 150:
                        zg1 = 169.7;
                        break;
                    default: return null;
                }
                //hier muss ein Zugriff auf die Datenbank mit der entsprechenden Tabelle implementiert werden!
                if (ag != null && zg != null && maisch_menge != null)
                {
                    if (ag > zg)
                        Console.WriteLine("Alert: Zielmostgewicht niedriger als Ausgangsmostgewicht!");
                    else if ((zg1 - ag1) > 16)
                    {
                        Console.WriteLine("Alert: Anreicherungsspanne von 16 g/l ist überschritten!");
                        //Ergebnisse berechnnen
                        double e1 = ag1;
                        double e2 = zg1 - ag1;
                        double e3 = zg1;
                        double e4 = Math.Ceiling((maisch_menge * zg - maisch_menge * ag) / zg);// oder durch zg1 -> erfragen!
                        double e5 = Math.Round(maisch_menge - e4);

                        //Ausgabe Ergebnisse
                        ergebnis.mg_e = e1;
                        Console.WriteLine(ergebnis.mg_e);
                        ergebnis.asp_e = e2;
                        Console.WriteLine(ergebnis.asp_e);
                        ergebnis.auf_alk = e3;
                        Console.WriteLine(ergebnis.auf_alk);
                        int e4_int = (int)e4;
                        ergebnis.perm_entzug = e4_int;
                        Console.WriteLine(ergebnis.perm_entzug);
                        int e5_int = (int)e5;
                        ergebnis.menge_konz = e5_int;
                        Console.WriteLine(ergebnis.menge_konz);
                    }
                    else
                    {
                        //Ergebnisse berechnnen
                        double e1 = ag1;
                        double e2 = zg1 - ag1;
                        double e3 = zg1;
                        double e4 = Math.Ceiling((maisch_menge * zg - maisch_menge * ag) / zg);// oder durch zg1 -> erfragen!
                        double e5 = Math.Round(maisch_menge - e4);

                        //Ausgabe Ergebnisse
                        ergebnis.mg_e = e1;
                        Console.WriteLine(ergebnis.mg_e);
                        ergebnis.asp_e = e2;
                        Console.WriteLine(ergebnis.asp_e);
                        ergebnis.auf_alk = e3;
                        Console.WriteLine(ergebnis.auf_alk);
                        int e4_int = (int)e4;
                        ergebnis.perm_entzug = e4_int;
                        Console.WriteLine(ergebnis.perm_entzug);
                        int e5_int = (int)e5;
                        ergebnis.menge_konz = e5_int;
                        Console.WriteLine(ergebnis.menge_konz);
                    }                                                                           
                }
                return null;
            }
            Ergebnis_konz test = new Ergebnis_konz() { };
            test = konzentration(60, 65, 100);
            Console.WriteLine();

            Ergebnis_konz test2 = new Ergebnis_konz() { };
            test2 = konzentration(65, 150, 730);
            Console.WriteLine();
            
            Ergebnis_konz test3 = new Ergebnis_konz() { };
            test3 = konzentration(65, 60, 200);
                
            Console.ReadKey();
        }
    }
}
