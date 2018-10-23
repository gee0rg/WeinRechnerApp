using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace WeinRechnerApp
{
    [Activity(Label = "WeinRechnerlel", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button _gotoVerschnitt;
        private Button _gotoRoteber;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

           
            SetContentView(Resource.Layout.activity_main);

            _gotoVerschnitt = FindViewById<Button>(Resource.Id.gotoVerschnitt);

            _gotoRoteber = FindViewById<Button>(Resource.Id.Roteber);
            _gotoVerschnitt.Click += GotoButton_Clicked;
        }


    

     private void GotoButton_Clicked(object sender, EventArgs e)
    {
       SetContentView(Resource.Layout.activity_Verschnitt);
    }
}
}

