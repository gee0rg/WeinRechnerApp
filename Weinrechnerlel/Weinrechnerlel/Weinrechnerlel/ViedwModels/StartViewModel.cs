using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Weinrechnerlel.ViedwModels
{
    public class StartViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _balken;
        private bool _los;

        public bool Balken
        {
            get => _balken; set
            {
                _balken = value;
                OnPropertyChanged();
            }
        }
        public Command Go { get; set; }
        public bool Los
        {
            get => _los; set
            {
                _los = value;
                OnPropertyChanged();
            }
        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
