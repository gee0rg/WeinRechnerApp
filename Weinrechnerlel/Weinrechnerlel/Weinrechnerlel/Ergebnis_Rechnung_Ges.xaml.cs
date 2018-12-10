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
        String liter_gv;

        public Ergebnis_Rechnung_Ges(Ergebnis_ges_VS ergebnis, String liter_gv)
        {


            InitializeComponent();
            liter_gw.Text = Convert.ToString(ergebnis.liter_gw);
            liter_vw.Text = Convert.ToString(ergebnis.liter_vw);
            liter_gw_prozent.Text = Convert.ToString(ergebnis.liter_gw_prozent);
            liter_vw_prozent.Text = Convert.ToString(ergebnis.liter_vw_prozent);
            this.liter_gv = liter_gv;

            //verb_liter1.Text = Convert.ToString(ergebnis.verb_liter1);
            //verb_liter075.Text = Convert.ToString(ergebnis.verb_liter075);
            //verb_liter05.Text = Convert.ToString(ergebnis.verb_liter05);
            //verb_liter0375.Text = Convert.ToString(ergebnis.verb_liter0375);
            //rest_liter.Text = Convert.ToString(ergebnis.rest_liter);
        }

        double rest_liter;

        private void verw_liter1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double liter1;
            double liter075;
            double liter05;
            double liter0375;


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
                liter05 = Convert.ToDouble(verw_liter05.Text);
            }
            catch
            {
                liter05 = 0;
            }
            try
            {
                liter0375 = Convert.ToDouble(verw_liter0375.Text);
            }
            catch
            {
                liter0375 = 0;
            }



            double a = Convert.ToDouble(liter_gv) - (liter1 + liter075 * 0.75 + liter05 * 0.5 + liter0375 * 0.375);
            rest_liter = a;
            double wert1 = Math.Round(rest_liter / 0.75);
            double wert2 = Math.Round(rest_liter / 0.5);
            double wert3 = Math.Round(rest_liter / 0.375);
           

            verw_liter1_erg.Text = Convert.ToString(Math.Floor(rest_liter));
            verw_liter075_erg.Text = Convert.ToString(wert1);
            verw_liter05_erg.Text = Convert.ToString(wert2);
            verw_liter0375_erg.Text = Convert.ToString(wert3);
        }
    }
}