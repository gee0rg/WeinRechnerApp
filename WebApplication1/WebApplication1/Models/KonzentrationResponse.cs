using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class KonzentrationResponse
    {
        public string EventMessage { get; set; }
        public int EventStatus { get; set; }
        public double mg_e { get; set; }
        public double asp_e { get; set; }
        
        public double auf_alk { get; set; }

        public int perm_entzug { get; set; }
        public int menge_konz { get; set; }

    }
}