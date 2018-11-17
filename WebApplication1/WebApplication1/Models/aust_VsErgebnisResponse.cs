using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class aust_VsErgebnisResponse
    {
            
        public int max_vw { get; set; }
        public int max_sr1 { get; set; }
        public int max_sr2 { get; set; }

        public int EventStatus { get; set; }
        public string EventMessage { get; set; }
    }
}
