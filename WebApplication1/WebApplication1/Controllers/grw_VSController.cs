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
    public class grw_VSController : ApiController
    {
        private static readonly ILogger _log =
      LoggingFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // POST api/grw_VS
        public grw_VSErgebnisResponse Post([FromBody] request_grw_VS param)
        {
            //Berechnung und Exception Handling
            grw_VSErgebnisResponse ergebnis = new grw_VSErgebnisResponse();

            //1. Berechnung
            double m4 = Convert.ToDouble(param.restzucker_sr) - Convert.ToDouble(param.restzucker_verschnitt);
            double m6 = Convert.ToDouble(param.restzucker_verschnitt) - Convert.ToDouble(param.restzucker_gw);
            double n4 = Convert.ToDouble(param.liter_gw) / m4;
            double o6 = m6 * n4;
            double e1 = Convert.ToDouble(param.liter_gw) + o6;
            double e2 = o6;



            //2. Prüfung
            if (Convert.ToDouble(param.restzucker_gw) <= Convert.ToDouble(param.restzucker_verschnitt))
            { }
            else
            {
                ergebnis.EventStatus = 2;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }
            if (m4 >= 0)
            { }
            else
            {
                ergebnis.EventStatus = 2;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }
            if (m6 >= 0)
            { }
            else
            {
                ergebnis.EventStatus = 2;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }
            if (m4 > 0 && m6 > 0)
            {
                ergebnis.liter_gw = Convert.ToInt32(e1);
                ergebnis.liter_vw = Convert.ToInt32(e2);
              

            }
            else
            {
                ergebnis.EventStatus = 2;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }




            //3. % Prüfung
            double x8 = o6 / (e1 / 100);
            if (x8 <= 15.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                ergebnis.EventStatus = 0;
                return ergebnis;
            }
            else if (x8 > 15.00 && x8 <= 25.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                ergebnis.EventMessage = "Falls es sich bei dem Verschnittpartner um Wein handelt, ist der max. Verschnitt von 15% überschritten";
                ergebnis.EventStatus = 1;
                return ergebnis;

            }
            else if (x8 > 25.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                ergebnis.EventMessage = "Falls es sich bei dem Verschnittpartner um Süßreserve handelt, ist der max. Verschnitt von 25% überschritten";
                ergebnis.EventStatus = 1;
                return ergebnis;

            }
            ergebnis.EventStatus = 0;
            return ergebnis;
        }
    }
}
