﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ges_VSErgebnisResponse
    {

        public int liter_gw { get; set; }
        public int liter_vw { get; set; }
        public double liter_gw_prozent { get; set; }
        public double liter_vw_prozent { get; set; }

        public int EventStatus { get; set; }
        public string EventMessage { get; set; }
    }
}