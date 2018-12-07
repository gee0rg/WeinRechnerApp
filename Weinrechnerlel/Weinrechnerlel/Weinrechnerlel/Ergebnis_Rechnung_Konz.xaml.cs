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
    public partial class Ergebnis_Rechnung_Konz : ContentPage
    {
        public Ergebnis_Rechnung_Konz(Ergebnis_konz ergebnis)
        {



            InitializeComponent();
            mg_e.Text = Convert.ToString(ergebnis.mg_e);
            asp_e.Text = Convert.ToString(ergebnis.asp_e);
            auf_alk.Text = Convert.ToString(ergebnis.auf_alk);
            perm_entzug.Text = Convert.ToString(ergebnis.perm_entzug);
            menge_konz.Text = Convert.ToString(ergebnis.menge_konz);





        }

    }
}