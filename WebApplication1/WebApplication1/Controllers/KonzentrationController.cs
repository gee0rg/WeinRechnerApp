using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KonzentrationController : ApiController
    {
        private guterContext db = new guterContext();
        public KonzentrationResponse Post([FromBody] request_Konzentration param)
        {
            KonzentrationResponse ergebnis = new KonzentrationResponse();
            Mostgw zgModel = new Mostgw();
            Mostgw agModel = new Mostgw();


            double eingabe_user_maisch_menge;
            try
            {
                eingabe_user_maisch_menge = Convert.ToDouble(param.maisch_menge);
            }
            catch
            {
                ergebnis.EventMessage = "Es sind Zahlen einzugeben";
                ergebnis.EventStatus = -1;
                return ergebnis;
            }
            if (eingabe_user_maisch_menge < 0)
            {
                ergebnis.EventMessage = "Ihre Eingabe muss positiv sein";
                ergebnis.EventStatus = -1;
                return ergebnis;
            }

            double ag;
            double zg;


            try
            {

                int i = Convert.ToInt32(param.ag);

                IEnumerable<Mostgw> agIE = db.Mostgws.Where(p => p.Id == i);
                if (agIE.Any())
                {
                    agModel = agIE.FirstOrDefault();



                }
            }
            catch (Exception)
            {
                ergebnis.EventStatus = -1;
                ergebnis.EventMessage = "Fehler beim Zugriff auf die Datenbank";
                return ergebnis;

            }

            try
            {

                int i = Convert.ToInt32(param.zg);

                IEnumerable<Mostgw> zgIE = db.Mostgws.Where(p => p.Id == i);
                if (zgIE.Any())
                {
                    zgModel = zgIE.FirstOrDefault();



                }
            }
            catch (Exception)
            {
                ergebnis.EventStatus = -1;
                ergebnis.EventMessage = "Fehler beim Zugriff auf die Datenbank";
                return ergebnis;

            }

            ag = Convert.ToDouble(agModel.mg);
            zg = Convert.ToDouble(zgModel.mg);





            if (Convert.ToInt32(param.ag) > Convert.ToInt32(param.zg))
            {


                ergebnis.EventMessage = "Zielmostgewicht niedriger als Ausgangsmostgewicht!";
                ergebnis.EventStatus = -1;
                return ergebnis;



            }





            else if ((zg - ag) > 16)
            {

                ergebnis.EventMessage = "Anreicherungsspanne von 16 g/l ist überschritten!";
                ergebnis.EventStatus = 1;
                //Ergebnisse berechnnen
                double e1 = ag;
                double e2 = zg - ag;
                double e3 = zg;
                double e4 = Convert.ToDouble(param.maisch_menge) * Convert.ToDouble(param.zg) - (Convert.ToDouble(param.maisch_menge) * Convert.ToDouble(param.ag));
                double e4_1 = Math.Round(e4 / Convert.ToDouble(param.zg));
                double e5 = Math.Round(Convert.ToDouble(param.maisch_menge) - e4_1);

                //Ausgabe Ergebnisse
                ergebnis.mg_e = e1;
                ergebnis.asp_e = e2;
                ergebnis.auf_alk = e3;
                int e4_int = Convert.ToInt32(e4_1);
                ergebnis.perm_entzug = e4_int;
                int e5_int = Convert.ToInt32(e5);
                ergebnis.menge_konz = e5_int;
                ergebnis.EventStatus = 0;
                return ergebnis;


            }
            else // else-Berechnung ,macht keinen Sinn 
            {
                //Ergebnisse berechnnen
                double e1 = ag;
                double e2 = zg - ag;
                double e3 = zg;
                double e4 = Convert.ToDouble(param.maisch_menge) * Convert.ToDouble(param.zg) - (Convert.ToDouble(param.maisch_menge) * Convert.ToDouble(param.ag));
                double e4_1 = Math.Round(e4 / Convert.ToDouble(param.zg));
                double e5 = Math.Round(Convert.ToDouble(param.maisch_menge) - e4_1);

                //Ausgabe Ergebnisse
                ergebnis.mg_e = e1;

                ergebnis.asp_e = Math.Round(e2,1);

                ergebnis.auf_alk = e3;

                int e4_int = Convert.ToInt32(e4_1);
                ergebnis.perm_entzug = e4_int;

                int e5_int = Convert.ToInt32(e5);
                ergebnis.menge_konz = e5_int;
                ergebnis.EventStatus = 0;
                return ergebnis;
            }
                
        }
    }
}
