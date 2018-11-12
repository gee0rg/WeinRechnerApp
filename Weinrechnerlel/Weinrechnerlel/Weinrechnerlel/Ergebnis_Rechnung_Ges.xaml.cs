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
       
        public Ergebnis_Rechnung_Ges(Ergebnis1_ges_VS ergebnis)
        {
       
          
            InitializeComponent();
            liter_gw.Text = Convert.ToString(ergebnis.liter_gw);
            liter_vw.Text = Convert.ToString(ergebnis.liter_vw);
            liter_gw_prozent.Text = Convert.ToString(ergebnis.liter_gw_prozent);
            liter_vw_prozent.Text = Convert.ToString(ergebnis.liter_vw_prozent);
        }



    }
}