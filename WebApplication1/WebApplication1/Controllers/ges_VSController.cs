using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Logging;

namespace WebApplication1.Controllers
{
    public class ges_VSController : ApiController
    {

        public ges_VSErgebnisResponse Post([FromBody] request_ges_VS param)
        {

            ges_VSErgebnisResponse ergebnis = new ges_VSErgebnisResponse();
            //1. Berechnung
            double x1 = Convert.ToDouble(param.restzucker_vw) - Convert.ToDouble(param.restzucker_verschnitt);
            double x2 = Convert.ToDouble(param.restzucker_verschnitt) - Convert.ToDouble(param.restzucker_gw);
            double x3 = x1 + x2;
            double x4 = Convert.ToDouble(param.liter_gv) / x3;
            double x5 = x4 * x1;
            double x6 = x4 * x2;
            // double x7 = x5 + x6;
            //2. Prüfung
            if (Convert.ToDouble(param.restzucker_gw) <= Convert.ToDouble(param.restzucker_verschnitt))
            { }
            else
            {
                ergebnis.EventStatus = 500;
                ergebnis.EventMessage = ("Parameter falsch");
                
                return ergebnis;
            }
            if (x1 >= 0)
            { }
            else
            {
                ergebnis.EventStatus = 500;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }
            if (x2 >= 0)
            { }
            else
            {
                ergebnis.EventStatus = 500;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }
            if (x1 > 0 && x2 > 0)
            {
                ergebnis.liter_gw = Convert.ToInt32(x5);
                ergebnis.liter_vw = Convert.ToInt32(x6);
                
            }
            else
            {
                ergebnis.EventStatus = 500;
                ergebnis.EventMessage = ("Parameter falsch");

                return ergebnis;
            }
            //3. % Prüfung
            double x8 = x6 / (Convert.ToDouble(param.liter_gv) / 100);
            if (x8 <= 15.00)
            {
                double a = x5 / (Convert.ToDouble(param.liter_gv) / 100);
                double b = x6 / (Convert.ToDouble(param.liter_gv) / 100);
                ergebnis.liter_gw_prozent = Math.Round(a, 1);
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
              
                return ergebnis;
            }
            else if (x8 > 15.00 && x8 <= 25.00)
            {
                double a = x5 / (Convert.ToDouble(param.liter_gv) / 100);
                double b = x6 / (Convert.ToDouble(param.liter_gv) / 100);
                ergebnis.liter_gw_prozent = Math.Round(a, 1);
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                ergebnis.EventMessage = "Falls es sich bei dem Verschnittpartner um Wein handelt, ist er max. Verschnitt von 15% überschritten";
              
                return ergebnis;
            }
            else if (x8 > 25.00)
            {
                double a = x5 / (Convert.ToDouble(param.liter_gv) / 100);
                double b = x6 / (Convert.ToDouble(param.liter_gv) / 100);
                ergebnis.liter_gw_prozent = Math.Round(a, 1);
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                ergebnis.EventMessage = "Falls es sich bei dem Verschnittpartner um Süßreserve handelt, ist der max. Verschnitt von 25% überschritten";


                return ergebnis;
            }

            return ergebnis;
        }
    }
}

