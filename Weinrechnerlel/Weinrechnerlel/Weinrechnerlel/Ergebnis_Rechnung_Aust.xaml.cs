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
        public Ergebnis_Rechnung_Aust()
        {
            InitializeComponent();
        }

        Ergebnis_Aust_VS ergebnis = new Ergebnis_Aust_VS();


        void Berechnen_Austausch(Object sender, EventArgs e) { 

      
                
            //Teil 1
            double a = Convert.ToDouble(liter_gw.Text) / 0.85 - Convert.ToDouble(liter_gw.Text);
            double b = Math.Floor(a);
            ergebnis.max_vw = Convert.ToInt32(b);
            //Console.WriteLine(ergebnis.max_vw);

            double c = Convert.ToDouble(liter_gw.Text) / 0.75 - (Convert.ToDouble(liter_gw.Text) + ergebnis.max_vw);
            double d = Math.Floor(c);
            ergebnis.max_sr1 = Convert.ToInt32(d);
            //Console.WriteLine(ergebnis.max_sr1);

            //Teil 2
            //Console.WriteLine("Menge des Grundweines: " + liter_gw.Text);

            if (Convert.ToDouble(verw_vw.Text) <= Convert.ToDouble(ergebnis.max_vw))
            {

                if (verw_vw.Text != null)
                {
                    double x = c + (b - Convert.ToDouble(verw_vw.Text));
                    double y = Math.Floor(x);
                    ergebnis.max_sr2 = Convert.ToInt32(y);
                    //Console.WriteLine(ergebnis.max_sr2);
                }
                
            }
            else
            {
                DisplayAlert("Alert", "Menge überschritten :(", "OK");
                return;

            }
            NavigationPage nav = new NavigationPage(new Nav_Aust_VS(ergebnis)) { BarBackgroundColor = Color.DarkRed };
            Navigation.PushAsync(nav);


        }
    }
}
