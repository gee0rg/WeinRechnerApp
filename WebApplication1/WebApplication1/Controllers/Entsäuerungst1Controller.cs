using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Entsäuerungst1Controller : ApiController
    {
        public EntsäuerungResponse Post([FromBody] request_Entsäuerung param)
        {
            EntsäuerungResponse entres = new EntsäuerungResponse();
            try
            {

                param.gs_von = param.gs_von.Replace(',', '.');
                double gs_von_1d = Convert.ToDouble(param.gs_von);


                param.gs_auf = param.gs_auf.Replace(',', '.');
                double gs_auf_1d = Convert.ToDouble(param.gs_auf);




                //Ergebnisse berechnnen
                double e1 = gs_von_1d - gs_auf_1d;
                double e2 = (Convert.ToDouble(param.em1) / 100.0) * (67.0 / 1000.0) * e1;

                //Ausgabe Ergebnisse
                entres.menge_ent1 = Math.Round(e2, 3);
                entres.um = e1;
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
