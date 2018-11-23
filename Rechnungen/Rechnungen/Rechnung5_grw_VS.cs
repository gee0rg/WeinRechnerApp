using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Rechnungen
{
    
    public class Ergebnis1_grw_VS
    {
        public int liter_gw { get; set; }
        public int liter_vw { get; set; }
        public double liter_gw_prozent { get; set; }
        public double liter_vw_prozent { get; set; }
    }

    public class Ergebnis2_grw_VS
    {
        public double verb_liter1;
        public double verb_liter075;
        public double verb_liter05;
        public double verb_liter0375;
        public double rest_liter;

    }
    class Rechnung5_grw_VS
    {

        static void Main(string[] args)
        {
           
        Ergebnis1_grw_VS ergebnis = new Ergebnis1_grw_VS() { };


        Ergebnis1_grw_VS Grw_VS(String liter_gw, String restzucker_gw, String restzucker_sr, String restzucker_verschnitt)
        {
            //1. Berechnung
            double m4 = Convert.ToDouble(restzucker_sr) - Convert.ToDouble(restzucker_verschnitt);
            double m6 = Convert.ToDouble(restzucker_verschnitt) - Convert.ToDouble(restzucker_gw);
            double n4 = Convert.ToDouble(liter_gw) / m4;
            double o6 = m6 * n4;
            double e1 = Convert.ToDouble(liter_gw) + o6;
            double e2 = o6;



            //2. Prüfung
            if (Convert.ToDouble(restzucker_gw) <= Convert.ToDouble(restzucker_verschnitt))
            { }
            else
            {
                Console.WriteLine("Eingabe prüfen");
                return null;
            }
            if (m4 >= 0)
            { }
            else
            {
                Console.WriteLine("Eingabe prüfen");
                return null;
            }
            if (m6 >= 0)
            { }
            else
            {
                Console.WriteLine("Eingabe prüfen");
                return null;
            }
            if (m4 > 0 && m6 > 0)
            {
                ergebnis.liter_gw = Convert.ToInt32(e1);
                ergebnis.liter_vw = Convert.ToInt32(e2);
                Console.WriteLine(ergebnis.liter_gw);
                Console.WriteLine(ergebnis.liter_vw);

            }
            else
            {
                Console.WriteLine("Eingabe prüfen");
                return null;
            }




            //3. % Prüfung
            double x8 = o6 / (e1 / 100);
            if (x8 <= 15.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                Console.WriteLine(ergebnis.liter_gw_prozent+ " %");
                Console.WriteLine(ergebnis.liter_vw_prozent+ " %");
                return ergebnis;
            }
            else if (x8 > 15.00 && x8 <= 25.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                Console.WriteLine("15% Meldung");
                return ergebnis;

            }
            else if (x8 > 25.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                Console.WriteLine(ergebnis.liter_vw_prozent + " %") ;
                Console.WriteLine("25% Meldung");
                return ergebnis;

            }

            return ergebnis;
        }

            
        Ergebnis2_grw_VS ergebnis2 = new Ergebnis2_grw_VS();

        Ergebnis2_grw_VS Grw_VS2( String verw_liter1, String verw_liter075, String verw_liter05, String verw_liter0375)
        {
            Console.WriteLine("ergibt Flaschen: ");
            Console.WriteLine(ergebnis.liter_gw);
            double x = Convert.ToDouble(ergebnis.liter_gw) / 0.75;
            Console.WriteLine(Convert.ToInt32(x));
            double y = Convert.ToDouble(ergebnis.liter_gw) / 0.5;
            Console.WriteLine(Convert.ToInt32(y));
            double z = Convert.ToDouble(ergebnis.liter_gw) / 0.375;
            Console.WriteLine(Convert.ToInt32(z));


            double a = Convert.ToDouble(ergebnis.liter_gw) - (Convert.ToDouble(verw_liter1) + Convert.ToDouble(verw_liter075) * 0.75 + Convert.ToDouble(verw_liter05) * 0.5 + Convert.ToDouble(verw_liter0375) * 0.375);
            ergebnis2.rest_liter = a;
            ergebnis2.verb_liter1 = ergebnis2.rest_liter;
            ergebnis2.verb_liter075 = ergebnis2.rest_liter / 0.75;
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

        Ergebnis1_grw_VS s = new Ergebnis1_grw_VS() { };
        s = Grw_VS("5000", "2", "20", "5");

        Ergebnis2_grw_VS t = new Ergebnis2_grw_VS() { };
        t = Grw_VS2( "1000", "2000", "3000", "1000");





        Console.ReadKey();
        }
    }
}*/
