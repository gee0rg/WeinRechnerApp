using System;
using System.Collections.Generic;
using System.Text;

namespace Weinrechnerlel.Models
{
    class AnreichRestResponse
    {

        public double mg_e { get; set; }
        public double asp_e { get; set; }
        public double auf_alk { get; set; }
        public String pa_e { get; set; }
        public double sach { get; set; }
        public double sach_ges { get; set; }
        public double mehr_an { get; set; }
        public double menge_an { get; set; }
        public int EventStatus { get; set; }
        public string EventMessage { get; set; }

    }
}

