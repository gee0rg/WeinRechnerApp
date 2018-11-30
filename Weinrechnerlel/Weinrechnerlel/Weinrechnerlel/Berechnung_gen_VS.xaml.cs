﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Weinrechnerlel.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;



namespace Weinrechnerlel
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Berechnung_gen_VS : ContentPage
    {
        



        public Berechnung_gen_VS()
        {
            InitializeComponent();
            liter_gw = test.Text;
        }
     

        Ergebnis_gen_Vs ergebnis = new Ergebnis_gen_Vs() { };

        string liter_gw { get; set; }
        

        void berechnung_gen(object sender, EventArgs e)
        {

            request_gen_VS param= new request_gen_VS(){liter_gw =test.Text };
            string request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();
            Ergebnis_gen_Vs ergebnis1 = new Ergebnis_gen_Vs() { };
            string answer;
            string adress = "http://10.141.77.226:4438/api/gen_Vs";
            //string adress = "http://localhost:50088/api/aust_Vs";

            answer = rconn.HTTP_POST(adress,request,50);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                //1. Berechnung
                double a;
                a = Convert.ToDouble(test.Text) / 0.85 - Convert.ToDouble(test.Text);
                double b = Math.Floor(a);
                ergebnis.max_vw = Convert.ToInt32(a);

                //2. Berechnung
                double x;
                x = Convert.ToDouble(test.Text) / 0.75 - Convert.ToDouble(test.Text);
                x = Math.Floor(x);
                ergebnis.max_sr1 = Convert.ToInt32(x);

                //3. Berechnung
                //Ausgabe max_sr2
                double z;
                z = (Convert.ToDouble(test.Text) / 0.75) - (Convert.ToDouble(ergebnis.max_vw) + Convert.ToDouble(test.Text));
                z = Math.Floor(z);
                ergebnis.max_sr2 = Convert.ToInt32(z);
                ergebnis.max_vw1 = ergebnis.max_vw;
            }
            else
            {
                genVSRestResponse erg = new genVSRestResponse() { };
                erg = JsonConvert.DeserializeObject<genVSRestResponse>(answer);
                if (erg.EventStatus != 0)
                {
                    DisplayAlert ("Hinweis", erg.EventMessage, "OK");
                      
                    return;
                }
                ergebnis.max_sr1 = erg.max_sr1;
                ergebnis.max_sr2 = erg.max_sr2;
                ergebnis.max_vw = erg.max_vw;
                ergebnis.max_vw1 = erg.max_vw;

                    

                
            }


            ;
            NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Gen(ergebnis)) { BarBackgroundColor = Color.DarkRed };
            Navigation.PushAsync(nav);

        }
   

    }
}