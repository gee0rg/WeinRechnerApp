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
        Ergebnis_Flaschen ergebnis2 = new Ergebnis_Flaschen() { };

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
        void berechnen2 (Object sender, EventArgs e)
        {
            
               // Console.WriteLine("ergibt Flaschen: ");
               //Console.WriteLine(ergebnis.liter_gw);
                double x = Convert.ToDouble(ergebnis.liter_gw) / 0.75;
               // Console.WriteLine(Convert.ToInt32(x));
                double y = Convert.ToDouble(ergebnis.liter_gw) / 0.5;
                //Console.WriteLine(Convert.ToInt32(y));
                double z = Convert.ToDouble(ergebnis.liter_gw) / 0.375;
               // Console.WriteLine(Convert.ToInt32(z));


                double a = Convert.ToDouble(ergebnis.liter_gw) - (Convert.ToDouble(verw_liter1.Text) + Convert.ToDouble(verw_liter075.Text) * 0.75 + Convert.ToDouble(verw_liter05.Text) * 0.5 + Convert.ToDouble(verw_liter0375.Text) * 0.375);
                ergebnis2.rest_liter = a;
                ergebnis2.verb_liter1 = ergebnis2.rest_liter;
                ergebnis2.verb_liter075 = ergebnis2.rest_liter / 0.75;
                ergebnis2.verb_liter05 = ergebnis2.rest_liter / 0.5;
                ergebnis2.verb_liter0375 = ergebnis2.rest_liter / 0.375;

               /* Console.WriteLine("verbleibende Flaschen: ");
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter1));
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter075));
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter05));
                Console.WriteLine(Convert.ToInt32(ergebnis2.verb_liter0375));
                Console.WriteLine("Restmenge in Litern: " + Convert.ToInt32(ergebnis2.rest_liter));*/
                
        }

          
        
    }
}

    
