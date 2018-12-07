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
                double ag1 = 0;
                switch (ag)
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

                double zg1 = 0;
                switch (zg)
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
                if (Convert.ToString(ag) != null && Convert.ToString(zg) != null && Convert.ToString(maisch_menge) != null)
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
                        double e4 = Math.Round((maisch_menge * zg - maisch_menge * ag) / zg);// oder durch zg1 -> erfragen!
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
                        double e4 = Math.Round((maisch_menge * zg - maisch_menge * ag) / zg);// oder durch zg1 -> erfragen!
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
            test = konzentration(78, 83, 96445);
            Console.WriteLine();

           /* Ergebnis_konz test2 = new Ergebnis_konz() { };
            test2 = konzentration(65, 150, 730);
            Console.WriteLine();
            
            Ergebnis_konz test3 = new Ergebnis_konz() { };
            test3 = konzentration(65, 60, 200);*/
                
            Console.ReadKey();
        }
    }
}
