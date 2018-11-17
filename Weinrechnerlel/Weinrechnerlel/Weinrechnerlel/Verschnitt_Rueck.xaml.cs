﻿using System;
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
	public partial class Verschnitt_Rueck : ContentPage
	{
		public Verschnitt_Rueck ()
		{
			InitializeComponent ();
		}

        Ergebnis_rueck_VS ergebnis = new Ergebnis_rueck_VS() { };

        void berechnen (Object sender, EventArgs e)
        {
            //Teil1
            double x1 = (Convert.ToDouble(liter_vw.Text) / 15) * 85;
            ergebnis.be_gw_mitSr_1 = Convert.ToInt32(Math.Floor(x1));

            double x2 = x1 / 0.75 - Convert.ToDouble(liter_vw.Text) - x1;
            ergebnis.max_sr1 = Convert.ToInt32(Math.Floor(x2));

            double x3 = x1 / 0.75;
            ergebnis.ges_menge_mitSr_1 = Convert.ToInt32(Math.Floor(x3));

            double x4 = x1;
            ergebnis.be_gw_ohneSr_1 = Convert.ToInt32(Math.Floor(x4));

            double x5 = x1 + Convert.ToDouble(liter_vw.Text);
            ergebnis.ges_menge_ohneSr_1 = Convert.ToInt32(Math.Floor(x5));

            //Teil2
            double x6 = (Convert.ToDouble(liter_sr.Text) / 25) * 75;
            ergebnis.be_gw_2 = Convert.ToInt32(Math.Floor(x6));

            double x7 = x6 / 0.75;
            ergebnis.ges_menge_2 = Convert.ToInt32(Math.Floor(x7));
            
            //Teil3
            double x8 = (Convert.ToDouble(liter_ges_vw.Text) / 100) * 75;
            ergebnis.be_gw_mitSr_3 = Convert.ToInt32(Math.Floor(x8));

            double x10 = x8 / 0.85 - x8;
            ergebnis.max_vw_mitSr_3 = Convert.ToInt32(Math.Floor(x10));

            double x9 = x8 / 0.75 - x10 - x8;
            ergebnis.max_sr3 = Convert.ToInt32(Math.Floor(x9));
            //In der Ausgabereihenfolge eigentlich umgekehrt

            double x11 = (Convert.ToDouble(liter_ges_vw.Text) / 100) * 85;
            ergebnis.be_gw_ohneSr_3 = Convert.ToInt32(Math.Floor(x11));

            double x12 = Convert.ToDouble(liter_ges_vw.Text) - x11;
            ergebnis.max_vw_ohneSr_3 = Convert.ToInt32(Math.Floor(x12));


            NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Rueck(ergebnis)) { BarBackgroundColor = Color.DarkRed };
            Navigation.PushAsync(nav);
        }

       
        
        
            

         
       
    }

	
}