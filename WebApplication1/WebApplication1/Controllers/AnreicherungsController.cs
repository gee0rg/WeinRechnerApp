using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AnreicherungsController : ApiController
    {
        private guterContext db = new guterContext();
        public AnreicherungsResponse Post([FromBody] request_Anreicherung param)
        {
            AnreicherungsResponse ergebnis = new AnreicherungsResponse();
            double pa_zahl = 0;


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

            double mg1 = Convert.ToDouble(param.mg);

            try
            {
                Mostgw mg = new Mostgw();
                int i = Convert.ToInt32(param.mg);

                IEnumerable<Mostgw> mgIE = db.Mostgws.Where(p => p.Id == i);
                if (mgIE.Any())
                {
                    mg = mgIE.FirstOrDefault();
                    mg1 = mg.mg;


                }
            }
            catch (Exception)
            {
                ergebnis.EventStatus=-1;

                return ergebnis;

            }


            try
            {
                prodart paa = new prodart();
                int i = Convert.ToInt32(param.pa);

                IEnumerable<prodart> paIE = db.Prodarts.Where(p => p.pa == i);
               
                if (paIE.Any())
                {
                    paa = paIE.FirstOrDefault();
                    pa_zahl = paa.pa_zahl;


                }
            }
            catch (Exception)
            {
                ergebnis.EventStatus = -1;

                return ergebnis;

            }




   
            double e1 = mg1;
            double e2 = Convert.ToDouble(param.asp);
            double e3 = mg1 + Convert.ToDouble(param.asp);
            string e4 = param.pa;
            double e5 = pa_zahl * Convert.ToDouble(param.asp) * 100 / 1000;
            double e6 = e5 * (Convert.ToDouble(param.maisch_menge) / 100);
            double e7 = Math.Round(e6 * 0.6);
            int e7_int = (int)e7;
            double e8 = Math.Round(Convert.ToDouble(param.maisch_menge) + e7);
            int e8_int = (int)e8;

            ergebnis.mg_e = e1;
            ergebnis.asp_e = e2;
            ergebnis.auf_alk = e3;
            ergebnis.pa_e = e4;
            ergebnis.sach = e5;
            ergebnis.sach_ges = e6;
            ergebnis.mehr_an = e7_int;
            ergebnis.menge_an = e8_int;
            return ergebnis;
            }
        }
    }
