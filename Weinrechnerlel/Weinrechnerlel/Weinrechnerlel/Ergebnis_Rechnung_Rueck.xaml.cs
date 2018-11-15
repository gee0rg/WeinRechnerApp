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
	public partial class Ergebnis_Rechnung_Rueck : ContentPage
	{
		public Ergebnis_Rechnung_Rueck (Ergebnis_rueck_VS ergebnis)
		{
			InitializeComponent ();
            //Teil 1
            be_gw_mitSr_1.Text = Convert.ToString(ergebnis.be_gw_mitSr_1);
            max_sr1.Text = Convert.ToString(ergebnis.max_sr1);
            ges_menge_mitSr_1.Text = Convert.ToString(ergebnis.ges_menge_mitSr_1);
            be_gw_ohneSr_1.Text = Convert.ToString(ergebnis.be_gw_ohneSr_1);
            ges_menge_ohneSr_1.Text = Convert.ToString(ergebnis.ges_menge_ohneSr_1);

            //Teil 2
            be_gw_2.Text = Convert.ToString(ergebnis.be_gw_2);
            ges_menge_2.Text = Convert.ToString(ergebnis.ges_menge_2);

            //Teil 3
            be_gw_mitSr_3.Text = Convert.ToString(ergebnis.be_gw_mitSr_3);
            max_sr3.Text = Convert.ToString(ergebnis.max_sr3);
            max_vw_mitSr_3.Text = Convert.ToString(ergebnis.max_vw_mitSr_3);
            be_gw_ohneSr_3.Text = Convert.ToString(ergebnis.be_gw_ohneSr_3);
            max_vw_ohneSr_3.Text = Convert.ToString(ergebnis.max_vw_ohneSr_3);

        }
}
}