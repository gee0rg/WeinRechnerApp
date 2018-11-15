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
	public partial class Ergebnis_Rechnung_Basis : ContentPage
	{
		public Ergebnis_Rechnung_Basis (Ergebnis_grw_VS ergebnis, Ergebnis_Flaschen ergebnis2 = null)
		{
			InitializeComponent ();
            liter_gw.Text = Convert.ToString(ergebnis.liter_gw);
            liter_vw.Text = Convert.ToString(ergebnis.liter_vw);
            liter_gw_prozent.Text = Convert.ToString(ergebnis.liter_gw_prozent);
            liter_vw_prozent.Text = Convert.ToString(ergebnis.liter_vw_prozent);

            if (ergebnis2 != null)
            {
                Ergebnis_Rechnung2_Basis(ergebnis2);
            }
        
        }
        

        public void Ergebnis_Rechnung2_Basis (Ergebnis_Flaschen ergebnis2)
        {
            InitializeComponent();
            verb_liter1.Text = Convert.ToString(ergebnis2.verb_liter1);
            verb_liter075.Text = Convert.ToString(ergebnis2.verb_liter075);
            verb_liter05.Text = Convert.ToString(ergebnis2.verb_liter05);
            verb_liter0375.Text = Convert.ToString(ergebnis2.verb_liter0375);
            rest_liter.Text = Convert.ToString(ergebnis2.rest_liter);
        }
	}
    
}