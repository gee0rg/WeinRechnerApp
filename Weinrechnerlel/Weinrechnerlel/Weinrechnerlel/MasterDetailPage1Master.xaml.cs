using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public ListView ListView;

        public MasterDetailPage1Master()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPage1MenuItem> MenuItems { get; set; }

            public MasterDetailPage1MasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPage1MenuItem>(new[]
                {
                    
                    new MasterDetailPage1MenuItem { Id = 0, Title = "Verschnitt generell", TargetType= typeof(Berechnung_gen_VS) },
                    new MasterDetailPage1MenuItem { Id = 1, Title = "Verschnitt Basis" , TargetType= typeof(Verschnitt_Basis) },
                    new MasterDetailPage1MenuItem { Id = 2, Title = "Verschnitt Gesamtmenge", TargetType = typeof(Verschnitt_Gesamtmenge)},
                    new MasterDetailPage1MenuItem { Id = 3, Title = "Verschnitt Austausch", TargetType = typeof(Verschnitt_Aust)},
                    new MasterDetailPage1MenuItem { Id = 4, Title = "Verschnitt Rückrechnung", TargetType = typeof (Verschnitt_Rueck)},
                    new MasterDetailPage1MenuItem { Id = 5, Title = "Impressum", TargetType= typeof(Impressum) },
                    new MasterDetailPage1MenuItem { Id = 6, Title = "Nutzungsbedingungen", TargetType=typeof(Nutzungsbedingungen)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}