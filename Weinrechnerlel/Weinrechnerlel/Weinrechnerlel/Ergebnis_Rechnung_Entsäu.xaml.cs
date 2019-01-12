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
	public partial class Ergebnis_Rechnung_Entsäu : ContentPage
	{
		public Ergebnis_Rechnung_Entsäu (Ergebnis_entsäu ergebnis)
		{
        //Darstellung Ergebnisse
		InitializeComponent ();
        //Teil 1
        menge_ent1.Text = Convert.ToString(ergebnis.menge_ent1);
        um.Text = Convert.ToString(ergebnis.um);

        //Teil 2
        menge_ent2.Text = Convert.ToString(ergebnis.menge_ent2);
        most_ent.Text = Convert.ToString(ergebnis.most_ent);
        wein_ent.Text = Convert.ToString(ergebnis.wein_ent);
        auf.Text = Convert.ToString(ergebnis.auf);
        }
	}
}