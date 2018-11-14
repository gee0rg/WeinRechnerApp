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
	public partial class Verschnitt_Basis : ContentPage
	{
		public Verschnitt_Basis ()
		{
			InitializeComponent ();
		}
        Ergebnis_grw_VS ergebnis = new Ergebnis_grw_VS() { };

        void berechnen(object sender, EventArgs e)
        {
            //1. Berechnung
            double m4 = Convert.ToDouble(restzucker_sr.Text) - Convert.ToDouble(restzucker_verschnitt.Text);
            double m6 = Convert.ToDouble(restzucker_verschnitt.Text) - Convert.ToDouble(restzucker_gw.Text);
            double n4 = Convert.ToDouble(liter_gw.Text) / m4;
            double o6 = m6 * n4;
            double e1 = Convert.ToDouble(liter_gw.Text) + o6;
            double e2 = o6;

            //2. Prüfung
            if (Convert.ToDouble(restzucker_gw.Text) <= Convert.ToDouble(restzucker_verschnitt.Text))
            { }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;

            }
            if (m4 >= 0)
            { }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
            }
            if (m6 >= 0)
            { }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
            }
            if (m4 > 0 && m6 > 0)
            {
                ergebnis.liter_gw = Convert.ToInt32(e1);
                ergebnis.liter_vw = Convert.ToInt32(e2);
                Console.WriteLine(ergebnis.liter_gw);
                Console.WriteLine(ergebnis.liter_vw);

            }
            else
            {
                DisplayAlert("Alert", "Eingabe prüfen", "OK");
                return;
            }




            //3. % Prüfung
            double x8 = o6 / (e1 / 100);
            //double b;
            if (x8 <= 15.00)
            {
               double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
                //Console.WriteLine(ergebnis.liter_gw_prozent + " %");
                //Console.WriteLine(ergebnis.liter_vw_prozent + " %");
                //return ergebnis;

                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Basis(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);

            }
            else if (x8 > 15.00 && x8 <= 25.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
               // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
               // Console.WriteLine(ergebnis.liter_vw_prozent + " %");
               // Console.WriteLine("15% Meldung");
               // return ergebnis;


                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Basis(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);

            }
            else if (x8 > 25.00)
            {
                double b = o6 / (e1 / 100);
                ergebnis.liter_gw_prozent = 100;
                ergebnis.liter_vw_prozent = Math.Round(b, 1);
               // Console.WriteLine(ergebnis.liter_gw_prozent + " %");
               // Console.WriteLine(ergebnis.liter_vw_prozent + " %");
               // Console.WriteLine("25% Meldung");
               // return ergebnis;
                NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Basis(ergebnis)) { BarBackgroundColor = Color.DarkRed };
                Navigation.PushAsync(nav);

            }



        }

    }
}

    
