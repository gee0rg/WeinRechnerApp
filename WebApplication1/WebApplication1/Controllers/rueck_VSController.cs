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
    public class rueck_VSController : ApiController
    {
        private static readonly ILogger _log =
      LoggingFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // POST api/rueck_Vs
        public Ergebnis_rueck_VS_Response Post([FromBody] request_rueck_Vs param)
        {
            Ergebnis_rueck_VS_Response ergebnis = new Ergebnis_rueck_VS_Response();
            double x1 = (Convert.ToDouble(param.liter_vw) / 15) * 85;
            ergebnis.be_gw_mitSr_1 = Convert.ToInt32(Math.Floor(x1));

            double x2 = x1 / 0.75 - Convert.ToDouble(param.liter_vw) - x1;
            ergebnis.max_sr1 = Convert.ToInt32(Math.Floor(x2));

            double x3 = x1 / 0.75;
            ergebnis.ges_menge_mitSr_1 = Convert.ToInt32(Math.Floor(x3));

            double x4 = x1;
            ergebnis.be_gw_ohneSr_1 = Convert.ToInt32(Math.Floor(x4));

            double x5 = x1 + Convert.ToDouble(param.liter_vw);
            ergebnis.ges_menge_ohneSr_1 = Convert.ToInt32(Math.Floor(x5));


            double x6 = (Convert.ToDouble(param.liter_sr) / 25)*75;
            ergebnis.be_gw_2 = Convert.ToInt32(Math.Floor(x6));

            double x7 = x6 / 0.75;
            ergebnis.ges_menge_2 = Convert.ToInt32(Math.Floor(x7));

            //Teil3
            double x8 = (Convert.ToDouble(param.liter_ges_vw) / 100) * 75;
            ergebnis.be_gw_mitSr_3 = Convert.ToInt32(Math.Floor(x8));

            double x10 = x8 / 0.85 - x8;
            ergebnis.max_vw_mitSr_3 = Convert.ToInt32(Math.Floor(x10));

            double x9 = x8 / 0.75 - x10 - x8;
            ergebnis.max_sr3 = Convert.ToInt32(Math.Floor(x9));
            //In der Ausgabereihenfolge eigentlich umgekehrt

            double x11 = (Convert.ToDouble(param.liter_ges_vw) / 100) * 85;
            ergebnis.be_gw_ohneSr_3 = Convert.ToInt32(Math.Floor(x11));

            double x12 = Convert.ToDouble(param.liter_ges_vw) - x11;
            ergebnis.max_vw_ohneSr_3 = Convert.ToInt32(Math.Floor(x12));

            return ergebnis;
        }
    }
}
