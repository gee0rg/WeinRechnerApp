using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnungen
{
    public class Ergebnis_entsäu
    {
        //Teil 1
        public double menge_ent1 { get; set; }
        public double um { get; set; }

        //Teil 2
        public double ent_spanne { get; set; }
        public double menge_ent2 { get; set; }
        public int most_ent { get; set; }
        public int wein_ent { get; set; }
        public double auf { get; set; }

    }
    class Rechnung8_entsäu
    {
        static void Main(string[] args)
        {
            Ergebnis_entsäu ergebnis = new Ergebnis_entsäu();

            Ergebnis_entsäu entsäuerung(double gs_von, double gs_auf, double em1, double gs2, double ws, double em2, double ent_um)
            {
                //Teil 1
                switch (gs_von)
                {
                    case 5.2:
                        gs_von = 5.2;
                        break;
                    case 6.4:
                        gs_von = 6.4;
                        break;
                    case 19:
                        gs_von = 19.0;
                        break;
                }
                //Picker implementieren von 5,2 bis 19,0 in 0,2 Schritten

                switch (gs_auf)
                {
                    case 5.2:
                        gs_auf = 5.2;
                        break;
                    case 6.4:
                        gs_von = 6.4;
                        break;
                    case 20.0:
                        gs_auf = 20.0;
                        break;
                }
                //Picker implementieren von 5,2 bis 20,0 in 0,2 Schritten
                                
                //Ergebnisse berechnnen
                double e1 = gs_von - gs_auf;
                double e2 = (em1 / 100.0) * (67.0 / 1000.0) * e1;
                                
                //Ausgabe Ergebnisse
                ergebnis.menge_ent1 = e2;
                Console.WriteLine(ergebnis.menge_ent1);
                ergebnis.um = e1;
                Console.WriteLine(ergebnis.um);


                //Teil 2
                switch (gs2)
                {
                    case 5.2:
                        gs_von = 5.2;
                        break;
                    case 6.4:
                        gs_von = 6.4;
                        break;
                    case 19:
                        gs_von = 19.0;
                        break;
                }
                //Picker implementieren von 5,2 bis 20,0 in 0,2 Schritten
                switch (ws)
                {
                    case 1:
                        ws = 1.0;
                        break;
                    case 10:
                        ws = 10.0;
                        break;
                }
                //Picker implementieren von 1,0 bis 10,0 in 0,1 Schritten
                               
                //ergebnisse berechnen
                double e3 = gs2 * (ws - 0.5)/(gs2-ws);          //E1
                double e4 = gs2 - ent_um;                       //E5
                double e5 = ((gs2 - e4) * em2 * 0.67) / 1000;   //E2
                double e6 = em2 * ((gs2 - e4) / (gs2 - 2));     //E3
                double e7 = em2 * ((gs2 - e4) / (gs2 - 3));     //E4

                //Ausgabe Ergebnisse
                ergebnis.ent_spanne = e3;
                Console.WriteLine(ergebnis.ent_spanne);
                ergebnis.menge_ent2 = e5;
                Console.WriteLine(ergebnis.menge_ent2);
                ergebnis.most_ent = Convert.ToInt32(e6);
                Console.WriteLine(ergebnis.most_ent);
                ergebnis.wein_ent = Convert.ToInt32(e7);
                Console.WriteLine(ergebnis.wein_ent);
                ergebnis.auf = Convert.ToInt32(e4);
                Console.WriteLine(ergebnis.auf);
                return null;
            }

            Ergebnis_entsäu test = new Ergebnis_entsäu() { };
            test = entsäuerung(6.4, 5.2, 5231, 5.2, 1, 252, 1);

            

            Console.ReadKey();
        }
    }
}
