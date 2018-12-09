using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class gen_VsController : ApiController
    {
        private static readonly ILogger _log =
           LoggingFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // POST api/gen_VS
        public gen_VsErgebnisResponse Post([FromBody] request_gen_vs param)
        {
            gen_VsErgebnisResponse ergebnis = new gen_VsErgebnisResponse();

            double eingabe_user;
            try
            {
                try
                {
                   eingabe_user= Convert.ToDouble(param.liter_gw);
                }
                catch
                {
                    ergebnis.EventStatus = 1;
                    ergebnis.EventMessage = "Fehler: Es dürfen nur Zahlen eingegeben werden.";
                    return ergebnis;
                }
                if (eingabe_user<0)
                {
                    ergebnis.EventStatus = 2;
                    ergebnis.EventMessage = "Fehler: Es darf kein negativer Wert eingegeben werden.";
                    return ergebnis;
                }

                //1. Berechnung
                double a;
                a = Convert.ToDouble(param.liter_gw) / 0.85 - Convert.ToDouble(param.liter_gw);
                double b = Math.Floor(a);
                ergebnis.max_vw = Convert.ToInt32(a);
                //2. Berechnung
                double x;
                x = Convert.ToDouble(param.liter_gw) / 0.75 - Convert.ToDouble(param.liter_gw);
                x = Math.Floor(x);
                ergebnis.max_sr1 = Convert.ToInt32(x);
                //3. Berechnung
                //Ausgabe max_sr2
                double z;
                z = (Convert.ToDouble(param.liter_gw) / 0.75) - (Convert.ToDouble(ergebnis.max_vw) + Convert.ToDouble(param.liter_gw));
                z = Math.Floor(z);
                ergebnis.max_sr2 = Convert.ToInt32(z);

            }
            catch (Exception e)
            {

                _log.Debug(string.Format("An unexpected error ocurred: {0}", e));
                ergebnis.EventStatus = 500;
                ergebnis.EventMessage = string.Format("An unexpected error ocurred: {0}", e);
                return ergebnis;

            }


            ergebnis.EventStatus = 0;
            return ergebnis;



        }

    }
}
