using System;
using System.Collections.Generic;
using System.Text;

namespace Weinrechnerlel.Models
{
   public class Ergebnis_grw_VS
    {
       
    public int liter_gw { get; set; }
    public int liter_vw { get; set; }
    public double liter_gw_prozent { get; set; }
    public double liter_vw_prozent { get; set; }

        public double verb_liter1 { get; set; }
        public double verb_liter075 { get; set; }
        public double verb_liter05 { get; set; }
        public double verb_liter0375 { get; set; }
        public double rest_liter { get; set; }

    }
}
