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
	public partial class Ergebnis_Rechnung_Aust : ContentPage
	{
		public Ergebnis_Rechnung_Aust(Ergebnis_Aust_VS ergebnis)
		{
 
			InitializeComponent ();
            max_vwe.Text = Convert.ToString(ergebnis.max_vw);
            max_sr1e.Text = Convert.ToString(ergebnis.max_sr1);
            
		}

        private void Verw_vw_TextChanged(object sender, TextChangedEventArgs e)
        {
            fr8.IsVisible = true;
            if (Convert.ToDouble(verw_vw.Text) <= Convert.ToDouble(max_sr1e.Text))
            {
                //Berechnung
                if (verw_vw.Text != null)
                {
                    double x = Convert.ToDouble(max_sr1e.Text) + (Convert.ToDouble(max_vwe.Text) - Convert.ToDouble(verw_vw.Text));
                    double y = Math.Floor(x);
                    int i;
                    i = Convert.ToInt32(y);
                    max_sr2e.Text = Convert.ToString(i);
                    //Console.WriteLine(ergebnis.max_sr2);
                }

            }
            //Alert
            else
            {
                DisplayAlert("Hinweis", "Verschnittweinanteil übersteigt maximale Menge", "OK");
                return;

            }
        }
    }
}