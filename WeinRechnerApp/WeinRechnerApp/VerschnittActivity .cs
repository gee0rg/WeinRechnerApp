using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WeinRechnerApp
{
    [Activity(Label = "Verschnittsberechnungen")]
    public class VerschnittActivity : Activity
    {
        private Button zurRechnung1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.activity_Verschnitt);

            zurRechnung1 = FindViewById<Button>(Resource.Id.genVerschnittt);


            zurRechnung1.Click += RechnungsButton_Clicked;

        }
        private void RechnungsButton_Clicked(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.activity_Verschnitt);
        }
    }
}