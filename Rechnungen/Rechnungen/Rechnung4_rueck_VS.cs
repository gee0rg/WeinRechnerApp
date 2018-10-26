using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Rechnungen
{
    public class Ergebnis_rueck_VS_1
    {
         //Teil 1
        public int be_gw_mitSr_1 { get; set; }
        public int max_sr1 { get; set; }
        public int ges_menge_mitSr_1 { get; set; }
        public int be_gw_ohneSr_1 { get; set; }
        public int ges_menge_ohneSr_1 { get; set; }
    }
    public class Ergebnis_rueck_VS_2
    {
        //Teil 2
        public int be_gw_2 { get; set; }
        public int ges_menge_2 { get; set; }
    }
    public class Ergebnis_rueck_VS_3
    {

        //Teil 3
        public int be_gw_mitSr_3 { get; set; }
        public int max_sr3 { get; set; }
        public int max_vw_mitSr_3 { get; set; }
        public int be_gw_ohneSr_3 { get; set; }
        public int max_vw_ohneSr_3 { get; set; }
    }


    class Rechnung4_rueck_VS
    {
        static void Main(string[] args)
        {
            Ergebnis_rueck_VS_1 ergebnis1 = new Ergebnis_rueck_VS_1() { };

            Ergebnis_rueck_VS_1 rueck_VS1(string liter_vw)
            {
                double x1 = (Convert.ToDouble(liter_vw) / 15) * 85;
                ergebnis1.be_gw_mitSr_1 = Convert.ToInt32(Math.Floor(x1));

                double x2 = x1 / 0.75 - Convert.ToDouble(liter_vw) - x1;
                ergebnis1.max_sr1 = Convert.ToInt32(Math.Floor(x2));

                double x3 = x1 / 0.75;
                ergebnis1.ges_menge_mitSr_1 = Convert.ToInt32(Math.Floor(x3));

                double x4 = x1;
                ergebnis1.be_gw_ohneSr_1 = Convert.ToInt32(Math.Floor(x4));

                double x5 = x1 + Convert.ToDouble(liter_vw);
                ergebnis1.ges_menge_ohneSr_1 = Convert.ToInt32(Math.Floor(x5));

                return ergebnis1;
            }

            Ergebnis_rueck_VS_2 ergebnis2 = new Ergebnis_rueck_VS_2() { };

            Ergebnis_rueck_VS_2 rueck_VS2(string liter_sr)
            {
                double x6 = (Convert.ToDouble(liter_sr) / 25) * 75;
                ergebnis2.be_gw_2 = Convert.ToInt32(Math.Floor(x6));

                double x7 = x6 / 0.75;
                ergebnis2.ges_menge_2 = Convert.ToInt32(Math.Floor(x7));

                return ergebnis2;
            }

            Ergebnis_rueck_VS_3 ergebnis3 = new Ergebnis_rueck_VS_3() { };

            Ergebnis_rueck_VS_3 rueck_VS3(string liter_ges_vw)
            {
                double x8 = (Convert.ToDouble(liter_ges_vw) / 100) * 75;
                ergebnis3.be_gw_mitSr_3 = Convert.ToInt32(Math.Floor(x8));

                double x10 = x8 / 0.85 - x8;
                ergebnis3.max_vw_mitSr_3 = Convert.ToInt32(Math.Floor(x10));

                double x9 = x8 / 0.75 - x10 - x8;
                ergebnis3.max_sr3 = Convert.ToInt32(Math.Floor(x9));
                //In der Ausgabereihenfolge eigentlich umgekehrt

                double x11 = (Convert.ToDouble(liter_ges_vw) / 100) * 85;
                ergebnis3.be_gw_ohneSr_3 = Convert.ToInt32(Math.Floor(x11));

                double x12 = Convert.ToDouble(liter_ges_vw) - x11;
                ergebnis3.max_vw_ohneSr_3 = Convert.ToInt32(Math.Floor(x12));

                return ergebnis3;
            }

            Ergebnis_rueck_VS_1 test1 = new Ergebnis_rueck_VS_1(){ };
            test1 = rueck_VS1("1600");

            //ausgabe
            Console.WriteLine(test1.be_gw_mitSr_1);
            Console.WriteLine(test1.max_sr1);
            Console.WriteLine(test1.ges_menge_mitSr_1);
            Console.WriteLine(test1.be_gw_ohneSr_1);
            Console.WriteLine(test1.ges_menge_ohneSr_1);


            Ergebnis_rueck_VS_2 test2 = new Ergebnis_rueck_VS_2() { };
            test2 = rueck_VS2("547,2");

            //ausgabe
            Console.WriteLine(test2.be_gw_2);
            Console.WriteLine(test2.ges_menge_2);

            Ergebnis_rueck_VS_3 test3 = new Ergebnis_rueck_VS_3() { };
            test3 = rueck_VS3("345,6");

            //ausgabe
            Console.WriteLine(test3.be_gw_mitSr_3);
            Console.WriteLine(test3.max_sr3);
            Console.WriteLine(test3.max_vw_mitSr_3);
            Console.WriteLine(test3.be_gw_ohneSr_3);
            Console.WriteLine(test3.max_vw_ohneSr_3);



            Console.ReadKey();
            
                                 
        }
    }


}*/

