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
    [Activity(Label = "WeinRechnerlel", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button _gotoVerschnitt;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            _gotoVerschnitt = FindViewById<Button>(Resource.Id.gotoVerschnitt);

            _gotoVerschnitt.Click += GotoButton_Clicked;
        }

        private void GotoButton_Clicked(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.activity_Verschnitt);
        }
    }
}

