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
       
        public Ergebnis_Rechnung_Basis(Ergebnis_grw_VS ergebnis)
        {
            InitializeComponent();
            liter_gw.Text = Convert.ToString(ergebnis.liter_gw);
            liter_vw.Text = Convert.ToString(ergebnis.liter_vw);
            liter_gw_prozent.Text = Convert.ToString(ergebnis.liter_gw_prozent);
            liter_vw_prozent.Text = Convert.ToString(ergebnis.liter_vw_prozent);
           
        }
        double rest_liter;

 

        private void verw_liter1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double liter1;
            double liter075;
            double liter05;
            double liter0375;


            fr0.IsVisible = true;
            fr1.IsVisible = true;
            fr2.IsVisible = true;
            fr3.IsVisible = true;

            try
            {
                 liter1 = Convert.ToDouble(verw_liter1.Text);
            }
            catch
            {
                 liter1 = 0;
            }
            try
            {
                 liter075 = Convert.ToDouble(verw_liter075.Text);
            }
            catch
            {
                 liter075 = 0;
            }

            try
            {
                 liter05= Convert.ToDouble(verw_liter05.Text);
            }
            catch
            {
                 liter05 = 0;
            }
            try
            {
                 liter0375= Convert.ToDouble(verw_liter0375.Text);
            }
            catch
            {
                 liter0375 = 0;
            }

            
            
            double a = Convert.ToDouble(liter_gw.Text) - (liter1 + liter075 * 0.75 + liter05 * 0.5 + liter0375 * 0.375);
            rest_liter = Math.Floor(a);
            double wert1 = Math.Round(rest_liter / 0.75);
            double wert2 = Math.Round(rest_liter / 0.5);
            double wert3 = Math.Round(rest_liter / 0.375);

            verw_liter1_erg.Text = Convert.ToString(rest_liter);
            verw_liter075_erg.Text = Convert.ToString(wert1);
            verw_liter05_erg.Text = Convert.ToString(wert2);
            verw_liter0375_erg.Text = Convert.ToString(wert3);
        }
    }
}