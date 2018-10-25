using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Rechnungen
{

    public class test
    {

        public int max_vw { get; set; }
        public int max_sr1 { get; set; }
        public int max_sr2 { get; set; }
    }
    class Rechnung1
    {
        static void Main(string[] args)
        {
            test ergebnis = new test() { };

            test Gen_VS(String liter_gw)
            {
                //1. Berechnung
                double a;
                a = Convert.ToDouble(liter_gw) / 0.85 - Convert.ToDouble(liter_gw);
                double b = Math.Floor(a);
                ergebnis.max_vw = Convert.ToInt32(a);

                //2. Berechnung
                double x;
                x = Convert.ToDouble(liter_gw) / 0.75 - Convert.ToDouble(liter_gw);
                x = Math.Floor(x);
                ergebnis.max_sr1 = Convert.ToInt32(x);

                //3. Berechnung
                //Ausgabe max_sr2
                double z;
                z = (Convert.ToDouble(liter_gw) / 0.75) - (Convert.ToDouble(ergebnis.max_vw) + Convert.ToDouble(liter_gw));
                z = Math.Floor(z);
                ergebnis.max_sr2 = Convert.ToInt32(z);

                return ergebnis;
            }
            test s = new test() { };
            s = Gen_VS("5000");
            Console.WriteLine(s.max_vw);
            Console.WriteLine(s.max_sr1);
            Console.WriteLine(s.max_sr2);


            Console.ReadKey();
        }
    }
}*/
