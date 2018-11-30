using System;
using System.Collections.Generic;
using System.Text;

namespace Weinrechnerlel.Models
{
    public class User_Response
    {
        public bool Nutzung { get; set; }
        public string id { get; set; }
        public int EventStatus { get; set; }
        public string EventMessage { get; set; }
    }
}
