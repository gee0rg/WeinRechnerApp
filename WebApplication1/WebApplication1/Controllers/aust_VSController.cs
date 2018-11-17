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
    public class aust_VSController : ApiController
    {
        private static readonly ILogger _log =
           LoggingFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // POST api/aust_VS
        public aust_VsErgebnisResponse Post([FromBody] request_aust_Vs param)
        {
            aust_VsErgebnisResponse ergebnis = new aust_VsErgebnisResponse();
            {
                //Teil 1
                double a = Convert.ToDouble(param.liter_gw) / 0.85 - Convert.ToDouble(param.liter_gw);
                double b = Math.Floor(a);
                ergebnis.max_vw = Convert.ToInt32(b);
               
                double c = Convert.ToDouble(param.liter_gw) / 0.75 - (Convert.ToDouble(param.liter_gw) + ergebnis.max_vw);
                double d = Math.Floor(c);
                ergebnis.max_sr1 = Convert.ToInt32(d);
                
                //Teil 2
               
                if (Convert.ToDouble(param.verw_vw) <= Convert.ToDouble(ergebnis.max_vw))
                {
                    if (param.verw_vw != null)
                    {
                        double x = c + (b - Convert.ToDouble(param.verw_vw));
                        double y = Math.Floor(x);
                        ergebnis.max_sr2 = Convert.ToInt32(y);
                        
                    }
                }
                else
                {
                    ergebnis.EventStatus = 500;
                    ergebnis.EventMessage = ("Menge überschriten :)");

                    return ergebnis;
                }
                return ergebnis;

            }
        }
    }
}
