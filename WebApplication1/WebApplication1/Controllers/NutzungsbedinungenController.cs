using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NutzungsbedinungenController : ApiController
    {
        //Anbindung an DB
        private guterContext db = new guterContext();

        public LoginResponseModel Post([FromBody] request_login param)
        {
            //Zustimmung der Nutzungsbedingungen
            User u = new User() { };
            LoginResponseModel lr = new LoginResponseModel() { };
            try
            {

                IEnumerable<User> UserIE = db.Users.Where(p => p.Id.ToLower() == param.Id.ToLower());
                if (UserIE.Any())
                {
                    u = UserIE.FirstOrDefault();
                    u.Nutzungsbedingungen = true;
                   
                    db.SaveChanges();
                    lr.id = u.Id;
                    lr.Nutzung = u.Nutzungsbedingungen;
                    lr.EventStatus = 0;
                    return lr;
                }
                else
                {
                    lr.EventStatus= - 1;
                    lr.EventMessage = "Kein User gefunden";
                    return lr;
                }
            }
            catch (Exception ex)
            {
                lr.EventStatus = -1;
                lr.EventMessage = string.Format("Exception: {0}", ex.Message);



                return lr;
            }

        }
    }
}
