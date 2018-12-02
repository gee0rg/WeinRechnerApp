using System;
using Weinrechnerlel.ViedwModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Weinrechnerlel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //StartViewModel sv = new StartViewModel() { };
            MainPage = new NavigationPage(new Startpage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
