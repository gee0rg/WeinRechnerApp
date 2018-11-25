using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LoginResponseModel
    {
        public bool Nutzung{ get; set; }
        public string id { get; set; }
        public int EventStatus { get; set; }
        public string EventMessage { get; set; }
    }
}