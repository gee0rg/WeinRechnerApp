using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public string Id { get; set; }
        public bool Nutzungsbedingungen { get; set; }

        public DateTime CreateDate { get; set; }
   

    }
}