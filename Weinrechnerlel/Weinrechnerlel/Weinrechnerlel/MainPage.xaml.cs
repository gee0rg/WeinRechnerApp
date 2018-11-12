using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.ViedwModels;
using Xamarin.Forms;

namespace Weinrechnerlel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewmodel(Navigation);
        }

        void bt_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new MasterDetailPage1());

        }
       
    }
}
