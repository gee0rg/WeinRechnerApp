using System;
using System.Collections.Generic;
using System.Text;

namespace Weinrechnerlel.Models
{
    public class Ergebnis_rueck_VS
    {
       
        //Teil 1
        public int be_gw_mitSr_1 { get; set; }
        public int max_sr1 { get; set; }
        public int ges_menge_mitSr_1 { get; set; }
        public int be_gw_ohneSr_1 { get; set; }
        public int ges_menge_ohneSr_1 { get; set; }
       
        //Teil 2
        public int be_gw_2 { get; set; }
        public int ges_menge_2 { get; set; }
        
        //Teil 3
        public int be_gw_mitSr_3 { get; set; }
        public int max_sr3 { get; set; }
        public int max_vw_mitSr_3 { get; set; }
        public int be_gw_ohneSr_3 { get; set; }
        public int max_vw_ohneSr_3 { get; set; }
        
    }
}
