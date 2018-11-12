using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weinrechnerlel
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        



        public MasterDetailPage1Detail()
        {
            InitializeComponent();
            liter_gw = test.Text;
        }
     

        Ergebnis_gen_Vs ergebnis = new Ergebnis_gen_Vs() { };

        string liter_gw { get; set; }
        

        void losrechne(object sender, EventArgs e)
        {
            //1. Berechnung
            double a;
            a = Convert.ToDouble(test.Text) / 0.85 - Convert.ToDouble(test.Text);
            double b = Math.Floor(a);
            ergebnis.max_vw = Convert.ToInt32(a);

            //2. Berechnung
            double x;
            x = Convert.ToDouble(test.Text) / 0.75 - Convert.ToDouble(test.Text);
            x = Math.Floor(x);
            ergebnis.max_sr1 = Convert.ToInt32(x);

            //3. Berechnung
            //Ausgabe max_sr2
            double z;
            z = (Convert.ToDouble(test.Text) / 0.75) - (Convert.ToDouble(ergebnis.max_vw) + Convert.ToDouble(test.Text));
            z = Math.Floor(z);
            ergebnis.max_sr2 = Convert.ToInt32(z);

          

            



            NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Gen(ergebnis)) { BarBackgroundColor = Color.DarkRed };
            Navigation.PushAsync(nav);

        }
   

    }
}