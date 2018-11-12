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
            
            
            //max_sr1e = zwei;
            //max_sr2e = drei;
            InitializeComponent();
            test = ergebnis;
            füllen();
        }
        void füllen()
        {
            String x;
            
        x = Convert.ToString(test.max_vw);
            max_vwe.Text = x;
               }
    }
}