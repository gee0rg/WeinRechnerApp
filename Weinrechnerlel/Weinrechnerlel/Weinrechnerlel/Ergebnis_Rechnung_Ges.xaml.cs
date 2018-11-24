using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Weinrechnerlel.Models;

namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ergebnis_Rechnung_Ges : ContentPage
    {


        public Ergebnis_Rechnung_Ges(Ergebnis_ges_VS ergebnis)
        {


            InitializeComponent();
            liter_gw.Text = Convert.ToString(ergebnis.liter_gw);
            liter_vw.Text = Convert.ToString(ergebnis.liter_vw);
            liter_gw_prozent.Text = Convert.ToString(ergebnis.liter_gw_prozent);
            liter_vw_prozent.Text = Convert.ToString(ergebnis.liter_vw_prozent);

            verb_liter1.Text = Convert.ToString(ergebnis.verb_liter1);
            verb_liter075.Text = Convert.ToString(ergebnis.verb_liter075);
            verb_liter05.Text = Convert.ToString(ergebnis.verb_liter05);
            verb_liter0375.Text = Convert.ToString(ergebnis.verb_liter0375);
            rest_liter.Text = Convert.ToString(ergebnis.rest_liter);
        }
            /* if (ergebnis2 != null)
             {
                 Ergebnis_Rechnung2_Ges(ergebnis2);
             }
         }


         public void Ergebnis_Rechnung2_Ges (Ergebnis_ges_VS ergebnis2)
         {
             InitializeComponent();
             verb_liter1.Text = Convert.ToString(ergebnis2.verb_liter1);
             verb_liter075.Text = Convert.ToString(ergebnis2.verb_liter075);
             verb_liter05.Text = Convert.ToString(ergebnis2.verb_liter05);
             verb_liter0375.Text = Convert.ToString(ergebnis2.verb_liter0375);
             rest_liter.Text = Convert.ToString(ergebnis2.rest_liter);
         }*/



        }
}