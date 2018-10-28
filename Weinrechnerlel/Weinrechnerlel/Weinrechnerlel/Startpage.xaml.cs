using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.ViedwModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weinrechnerlel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Startpage : ContentPage
	{
		public Startpage ()
		{
			InitializeComponent ();
            BindingContext = new StartViewModel();
        }
        void StartButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());
            
        }
    }
}