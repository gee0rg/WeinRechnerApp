using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EntsäuerungsTeil2Controller : ApiController
    {
        public EntsäuerungResponse Post([FromBody] request_Entsäuerung param)
        {
            EntsäuerungResponse entres = new EntsäuerungResponse();
            try
            {


                param.gs2 = param.gs2.Replace(',', '.');
                double gs2_1d = Convert.ToDouble(param.gs2, new System.Globalization.CultureInfo("en-US"));


                 
                //ergebnisse berechnen
                double test = Convert.ToDouble(param.ent_um, new System.Globalization.CultureInfo("en-US"));
                double e4 = gs2_1d - test;                         //E5
                double e5 = ((gs2_1d - e4) * Convert.ToDouble(param.em2) * 0.67) / 1000;     //E2
                double e6 = Convert.ToDouble(param.em2, new System.Globalization.CultureInfo("en-US")) * ((gs2_1d - e4) / (gs2_1d - 2));    //E3
                double e7 = Convert.ToDouble(param.em2, new System.Globalization.CultureInfo("en-US")) * ((gs2_1d - e4) / (gs2_1d - 3));    //E4

                //Ausgabe Ergebnisse

                entres.menge_ent2 = e5;
                entres.most_ent = Convert.ToInt32(e6);
                entres.wein_ent = Convert.ToInt32(e7);
                entres.auf = e4;
                return entres;
            }
            catch
            {
                entres.EventStatus = -1;
                entres.EventMessage = "Fehler";
                return entres;
            }
        }
    }
}
