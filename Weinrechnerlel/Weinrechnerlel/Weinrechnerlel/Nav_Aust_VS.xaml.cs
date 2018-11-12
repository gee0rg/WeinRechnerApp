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
	public partial class Nav_Aust_VS : ContentPage
	{
		public Nav_Aust_VS(Ergebnis_Aust_VS ergebnis2)
		{
 
			InitializeComponent ();

		}
	}
}