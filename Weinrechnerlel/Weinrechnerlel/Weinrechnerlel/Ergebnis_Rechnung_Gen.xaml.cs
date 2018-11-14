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
    public partial class Ergebnis_Rechnung_Gen : ContentPage
    {
        Ergebnis_gen_Vs test = new Ergebnis_gen_Vs();
        public Ergebnis_Rechnung_Gen(Ergebnis_gen_Vs ergebnis)
        {
            
            
            
            InitializeComponent();
            max_vwe.Text = Convert.ToString(ergebnis.max_vw);
            max_sr1e.Text = Convert.ToString(ergebnis.max_sr1);
            max_sr2e.Text = Convert.ToString(ergebnis.max_sr2);

           
        }
        
    }
}