using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EntsäuerungResponse
    {
        //Teil 1
        public double menge_ent1 { get; set; }
        public double um { get; set; }

        //Teil 2
        public double ent_spanne { get; set; }
        public double menge_ent2 { get; set; }
        public int most_ent { get; set; }
        public int wein_ent { get; set; }
        public double auf { get; set; }

        public int EventStatus { get; set; }
        public string EventMessage { get; set; }
    }
}