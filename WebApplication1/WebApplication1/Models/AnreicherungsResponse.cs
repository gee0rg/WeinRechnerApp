using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class AnreicherungsResponse
    {
        public double mg_e { get; set; }
        public double asp_e { get; set; }
        public double auf_alk { get; set; }
        public String pa_e { get; set; }
        public double sach { get; set; }
        public double sach_ges { get; set; }
        public int mehr_an { get; set; }
        public int menge_an { get; set; }
        public int EventStatus { get; set; }
        public string EventMessage { get; set; }
    }
}