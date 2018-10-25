using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Rechnungen
{


   public class Ergebnis1_ges_VS {
    public int liter_gw { get; set; }
        public int liter_vw { get; set; }
        public double liter_gw_prozent { get; set; }
        public double liter_vw_prozent { get; set; }
    }

    public class Ergebnis2_ges_VS
    {
        public double verb_liter1;
        public double verb_liter075;
        public double verb_liter05;
        public double verb_liter0375;
        public double rest_liter;

    }


    class Rechnung2_ges_VS
    {
        
        static void Main(string[] args)
        {

            Ergebnis1_ges_VS ergebnis = new Ergebnis1_ges_VS() { };

            Ergebnis1_ges_VS Ges_VS(String liter_gv, String restzucker_gw, String restzucker_vw, String restzucker_verschnitt)
            {
                //1. Berechnung
                double x1 = Convert.ToDouble(restzucker_vw) - Convert.ToDouble(restzucker_verschnitt);
                double x2 = Convert.ToDouble(restzucker_verschnitt) - Convert.ToDouble(restzucker_gw);
                double x3 = x1 + x2;
                double x4 = Convert.ToDouble(liter_gv) / x3;
                double x5 = x4 * x1;
                double x6 = x4 * x2;
                // double x7 = x5 + x6;

                //2. Prüfung
                if (Convert.ToDouble(restzucker_gw) <= Convert.ToDouble(restzucker_verschnitt))
                { }
                else
                {
                    Console.WriteLine("Eingabe prüfen");
                    return null;
                }
                if (x1 >= 0)
                { }
                else
                {
                    Console.WriteLine("Eingabe prüfen");
                    return null;
                }
                if (x2 >= 0)
                { }
                else
                {
                    Console.WriteLine("Eingabe prüfen");
                    return null;
                }
                if (x1 > 0 && x2 > 0)
                {
                    ergebnis.liter_gw = Convert.ToInt32(x5);
                    ergebnis.liter_vw = Convert.ToInt32(x6);
                    Console.WriteLine(ergebnis.liter_gw);
                    Console.WriteLine(ergebnis.liter_vw);

                }
                else
                {
                    Console.WriteLine("Eingabe prüfen");
                    return null;
                }




                //3. % Prüfung
                double x8 = x6 / (Convert.ToDouble(liter_gv) / 100);
                if (x8 <= 15.00)
                {
                    double a = x5 / (Convert.ToDouble(liter_gv) / 100);
                    double b = x6 / (Convert.ToDouble(liter_gv) / 100);
                    ergebnis.liter_gw_prozent = Math.Round(a, 1);
                    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                    Console.WriteLine(ergebnis.liter_gw_prozent);
                    Console.WriteLine(ergebnis.liter_vw_prozent);
                    return ergebnis;
                }
                else if (x8 > 15.00 && x8 <= 25.00)
                {
                    double a = x5 / (Convert.ToDouble(liter_gv) / 100);
                    double b = x6 / (Convert.ToDouble(liter_gv) / 100);
                    ergebnis.liter_gw_prozent = Math.Round(a, 1);
                    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                    Console.WriteLine(ergebnis.liter_gw_prozent);
                    Console.WriteLine(ergebnis.liter_vw_prozent);
                    Console.WriteLine("15% Meldung");
                    return ergebnis;

                }
                else if (x8 > 25.00)
                {
                    double a = x5 / (Convert.ToDouble(liter_gv) / 100);
                    double b = x6 / (Convert.ToDouble(liter_gv) / 100);
                    ergebnis.liter_gw_prozent = Math.Round(a, 1);
                    ergebnis.liter_vw_prozent = Math.Round(b, 1);
                    Console.WriteLine(ergebnis.liter_gw_prozent);
                    Console.WriteLine(ergebnis.liter_vw_prozent);
                    Console.WriteLine("25% Meldung");
                    return ergebnis;

                }
                               
                return ergebnis;
            }

            Ergebnis2_ges_VS ergebnis2 = new Ergebnis2_ges_VS();

            Ergebnis2_ges_VS Ges_VS2 (String liter_gv, String verw_liter1, String verw_liter075, String verw_liter05, String verw_liter0375){
                Console.WriteLine("ergibt Flaschen: ");
                Console.WriteLine(liter_gv);
                double x = Convert.ToDouble(liter_gv) / 0.75;
                Console.WriteLine(Convert.ToInt32(x));
                double y = Convert.ToDouble(liter_gv) / 0.5;
                Console.WriteLine(Convert.ToInt32(y));
                double z = Convert.ToDouble(liter_gv) / 0.375;
                Console.WriteLine(Convert.ToInt32(z));


                double a = Convert.ToDouble(liter_gv) - (Convert.ToDouble(verw_liter1) + Convert.ToDouble(verw_liter075) * 0.75 + Convert.ToDouble(verw_liter05) * 0.5 + Convert.ToDouble(verw_liter0375) * 0.375);
                ergebnis2.rest_liter = a;
                ergebnis2.verb_liter1 = ergebnis2.rest_liter;
                ergebnis2.verb_liter075 = ergebnis2.rest_liter/ 0.75;
                ergebnis2.verb_liter05 = ergebnis2.rest_liter / 0.5;
                ergebnis2.verb_liter0375 = ergebnis2.rest_liter / 0.375;

                Console.WriteLine("verbleibende Flaschen: ");
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter1));
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter075));
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter05));
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter0375));
                Console.WriteLine("Restmenge in Litern: " + Convert.ToInt32(ergebnis2.rest_liter));
                return ergebnis2;


            }

            Ergebnis1_ges_VS s = new Ergebnis1_ges_VS() { };
            s = Ges_VS("5000", "0,4", "10", "1,2");

            Ergebnis2_ges_VS t = new Ergebnis2_ges_VS() { };
            t = Ges_VS2("5000", "3225", "2000", "400", "200");

            
            


            Console.ReadKey();
        }
    }
}*/
