using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersManagmentController : ApiController
    {
        //Anbindung an DB
        private guterContext db = new guterContext();







        public LoginResponseModel Post([FromBody] request_login param)
        {
            User u = new User() { };
            LoginResponseModel lr = new LoginResponseModel() { };
            //Prüfung, ob Nutzungsbedingungen akzeptiert wurden
            try
            {

                IEnumerable<User> UserIE = db.Users.Where(p =>  p.Id.ToLower() == param.Id.ToLower());
                if (UserIE.Any())
                {
                    u = UserIE.FirstOrDefault();
                    lr.id = u.Id;
                    lr.Nutzung = u.Nutzungsbedingungen;
                    lr.EventStatus = 2;
                    return lr;
                }
                else
                {


                    u.Nutzungsbedingungen = false;
                    u.CreateDate = DateTime.Now;
                    u.Id = Guid.NewGuid().ToString("N");
                    db.Users.Add(u);
                    db.SaveChanges();


                    lr.id = u.Id;
                    lr.Nutzung = u.Nutzungsbedingungen;
                    lr.EventStatus = 1;
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
