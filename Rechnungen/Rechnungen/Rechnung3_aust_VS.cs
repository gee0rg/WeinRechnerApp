using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungen
{
    public class Ergebnis_aust_VS
    {
        public int max_vw { get; set; }
        public int max_sr1 { get; set; }
        public int max_sr2 { get; set; }
    }

    class Rechnung3_aust_VS
    {
        static void Main(string[] args)
        {
            Ergebnis_aust_VS ergebnis = new Ergebnis_aust_VS();

            Ergebnis_aust_VS aust_VS (String liter_gw, String verw_vw)
            {
                //Teil 1
                double a = Convert.ToDouble(liter_gw) / 0.85 - Convert.ToDouble(liter_gw);
                double b = Math.Floor(a);
                ergebnis.max_vw = Convert.ToInt32(b);
                Console.WriteLine(ergebnis.max_vw);

                double c = Convert.ToDouble(liter_gw) / 0.75 - (Convert.ToDouble(liter_gw) + ergebnis.max_vw);
                double d = Math.Floor(c);
                ergebnis.max_sr1 = Convert.ToInt32(d);
                Console.WriteLine(ergebnis.max_sr1);


                //Teil 2
                Console.WriteLine("Menge des Grundweines: "+liter_gw);

                if (Convert.ToDouble(verw_vw) <= Convert.ToDouble(ergebnis.max_vw))
                {

                    if (verw_vw != null)
                    {
                        double x = c + (b - Convert.ToDouble(verw_vw));
                        double y = Math.Floor(x);
                        ergebnis.max_sr2 = Convert.ToInt32(y);
                        Console.WriteLine(ergebnis.max_sr2);
                    }
                }
                else
                {
                    Console.WriteLine("Menge überschritten");

                }
                return ergebnis;


            }

            Ergebnis_aust_VS test = new Ergebnis_aust_VS();
            test = aust_VS("100", "5");
            
            
            
            Console.ReadKey();



        }
    }
}
