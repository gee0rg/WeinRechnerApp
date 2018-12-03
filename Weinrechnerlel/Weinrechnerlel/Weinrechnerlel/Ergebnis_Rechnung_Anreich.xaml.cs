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
    public partial class Ergebnis_Rechnung_Anreich : ContentPage
    {
        public Ergebnis_Rechnung_Anreich(Ergebnis_anreich ergebnis)
        {



            InitializeComponent();
            mg_e.Text = Convert.ToString(ergebnis.mg_e);
            asp_e.Text = Convert.ToString(ergebnis.asp_e);
            auf_alk.Text = Convert.ToString(ergebnis.auf_alk);
            pa_e.Text = Convert.ToString(ergebnis.pa_e);
            sach.Text = Convert.ToString(ergebnis.sach);
            sach_ges.Text = Convert.ToString(ergebnis.sach_ges);
            mehr_an.Text = Convert.ToString(ergebnis.mehr_an);
            menge_an.Text = Convert.ToString(ergebnis.menge_an);





        }

    }
}