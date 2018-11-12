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
    public partial class Verschnitt_Gesamtmenge : ContentPage
    {
        public Verschnitt_Gesamtmenge()
        {
            InitializeComponent();

        }

     


        public class Ergebnis2_ges_VS
        {

            public double verb_liter1 { get; set; }
            public double verb_liter075 { get; set; }
            public double verb_liter05 { get; set; }
            public double verb_liter0375 { get; set; }
            public double rest_liter { get; set; }


        }
        Ergebnis1_ges_VS ergebnis = new Ergebnis1_ges_VS() { };

        void Berechnen(object sender, EventArgs e)

        {
            //1. Berechnung
            double x1 = Convert.ToDouble(restzucker_vw.Text) - Convert.ToDouble(restzucker_verschnitt.Text);
            double x2 = Convert.ToDouble(restzucker_verschnitt.Text) - Convert.ToDouble(restzucker_gw.Text);
            double x3 = x1 + x2;
            double x4 = Convert.ToDouble(liter_gv.Text) / x3;
            double x5 = x4 * x1;
            double x6 = x4 * x2;
            // double x7 = x5 + x6;

            //2. Prüfung
            if (Convert.ToDouble(restzucker_gw.Text) <= Convert.ToDouble(restzucker_verschnitt.Text))
            { }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
                
            }
            if (x1 >= 0)
            { }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
            }
            if (x2 >= 0)
            { }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
            }
            if (x1 > 0 && x2 > 0)
            {
                ergebnis.liter_gw = Convert.ToInt32(x5);
                ergebnis.liter_vw = Convert.ToInt32(x6);
                Console.WriteLine(ergebnis.liter_gw);
                Console.WriteLine(ergebnis.liter_vw);

            }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
            }




            //3. % Prüfung
            double x8 = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
            if (x8 <= 15.00)
            {
                double a = x5 / (Convert.ToDouble(liter_gv.Text) / 100);
                double b = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                ergebnis.liter_gw_prozent = Math.Round(a, 1);
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                //Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                
               NavigationPage nav = new NavigationPage(new Page1(ergebnis)) {BarBackgroundColor=Color.DarkRed };
                Navigation.PushAsync(nav);

            }
            else if (x8 > 15.00 && x8 <= 25.00)
            {
                double a = x5 / (Convert.ToDouble(liter_gv.Text) / 100);
                double b = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                ergebnis.liter_gw_prozent = Math.Round(a, 1);
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                // Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                //Console.WriteLine("15% Meldung");

               
                NavigationPage nav = new NavigationPage(new Page1(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);

            }
            else if (x8 > 25.00)
            {
                double a = x5 / (Convert.ToDouble(liter_gv.Text) / 100);
                double b = x6 / (Convert.ToDouble(liter_gv.Text) / 100);
                ergebnis.liter_gw_prozent = Math.Round(a, 1);
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                //Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                //Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                //Console.WriteLine("25% Meldung");
                NavigationPage nav = new NavigationPage(new Page1(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);

            }


          
        }

    }
}