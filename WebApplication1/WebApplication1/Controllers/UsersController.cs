using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.WeinrechnerAppDB;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UsersController : ApiController
    {
        private Context db = new Context();






        public LoginResponseModel Post([FromBody] request_login param)
        {
            User u = new User() { };
            LoginResponseModel lr = new LoginResponseModel() { };

            try
            {

                IEnumerable<User> UserIE = db.User.Where(p => p.Id == param.Id);
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
                    db.User.Add(u);
                    db.SaveChanges();
                    IEnumerable<User> UserIEzwei = db.User.Where(p => p.CreateDate == u.CreateDate);
                    User uu = new User() { };
                    uu = UserIEzwei.FirstOrDefault();
                    lr.id = uu.Id;
                    lr.Nutzung = uu.Nutzungsbedingungen;
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

