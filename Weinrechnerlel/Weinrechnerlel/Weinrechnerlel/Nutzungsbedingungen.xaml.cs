using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weinrechnerlel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Nutzungsbedingungen : ContentPage
	{
        string user;
        public Nutzungsbedingungen() {
            InitializeComponent();
            UserManagment.IsVisible = false;
        }

        public Nutzungsbedingungen (User_Response user=null )
		{
            
			InitializeComponent ();
            if (user != null) {
                UserManagment.IsVisible = true;
                this.user = user.id;
                    }
            else
            {
                UserManagment.IsVisible = false;
            }
        }

        void NutzungsbedingungenButton_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushModalAsync(new MasterDetailPage1());

        }
	}
}