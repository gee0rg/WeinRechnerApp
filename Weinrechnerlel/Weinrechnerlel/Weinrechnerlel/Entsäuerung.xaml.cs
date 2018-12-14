using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Weinrechnerlel.Models;
using Newtonsoft.Json;

namespace Weinrechnerlel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entsäuerung : ContentPage
    {
        public Entsäuerung()
        {
            InitializeComponent();
            gesamtsäure_von.Items.Add("bitte auswählen");
            gesamtsäure_von.Items.Add("5,2");
            gesamtsäure_von.Items.Add("5,4");
            gesamtsäure_von.Items.Add("5,6");
            gesamtsäure_von.Items.Add("5,8");
            gesamtsäure_von.Items.Add("6,0");
            gesamtsäure_von.Items.Add("6,2");
            gesamtsäure_von.Items.Add("6,4");
            gesamtsäure_von.Items.Add("6,8");
            gesamtsäure_von.Items.Add("7,0");
            gesamtsäure_von.Items.Add("7,2");
            gesamtsäure_von.Items.Add("7,4");
            gesamtsäure_von.Items.Add("7,8");
            gesamtsäure_von.Items.Add("8,0");
            gesamtsäure_von.Items.Add("8,2");
            gesamtsäure_von.Items.Add("8,4");
            gesamtsäure_von.Items.Add("8,8");
            gesamtsäure_von.Items.Add("9,0");
            gesamtsäure_von.Items.Add("9,2");
            gesamtsäure_von.Items.Add("9,4");
            gesamtsäure_von.Items.Add("9,8");
            gesamtsäure_von.Items.Add("10,0");
            gesamtsäure_von.Items.Add("10,2");
            gesamtsäure_von.Items.Add("10,4");
            gesamtsäure_von.Items.Add("10,8");
            gesamtsäure_von.Items.Add("11,0");
            gesamtsäure_von.Items.Add("11,2");
            gesamtsäure_von.Items.Add("11,4");
            gesamtsäure_von.Items.Add("11,8");
            gesamtsäure_von.Items.Add("12,0");
            gesamtsäure_von.Items.Add("12,2");
            gesamtsäure_von.Items.Add("12,4");
            gesamtsäure_von.Items.Add("12,8");
            gesamtsäure_von.Items.Add("13,0");
            gesamtsäure_von.Items.Add("13,2");
            gesamtsäure_von.Items.Add("13,4");
            gesamtsäure_von.Items.Add("13,8");
            gesamtsäure_von.Items.Add("14,0");
            gesamtsäure_von.Items.Add("14,2");
            gesamtsäure_von.Items.Add("14,4");
            gesamtsäure_von.Items.Add("14,8");
            gesamtsäure_von.Items.Add("15,0");
            gesamtsäure_von.Items.Add("15,2");
            gesamtsäure_von.Items.Add("15,4");
            gesamtsäure_von.Items.Add("15,8");
            gesamtsäure_von.Items.Add("16,0");
            gesamtsäure_von.Items.Add("16,2");
            gesamtsäure_von.Items.Add("16,4");
            gesamtsäure_von.Items.Add("16,8");
            gesamtsäure_von.Items.Add("17,0");
            gesamtsäure_von.Items.Add("17,2");
            gesamtsäure_von.Items.Add("17,4");
            gesamtsäure_von.Items.Add("17,8");
            gesamtsäure_von.Items.Add("18,0");
            gesamtsäure_von.Items.Add("18,2");
            gesamtsäure_von.Items.Add("18,4");
            gesamtsäure_von.Items.Add("18,8");
            gesamtsäure_von.Items.Add("19,0");
            gesamtsäure_von.SelectedIndex = 0;

            gesamtsäure_auf.Items.Add("bitte auswählen");
            gesamtsäure_auf.Items.Add("5,2");
            gesamtsäure_auf.Items.Add("5,4");
            gesamtsäure_auf.Items.Add("5,6");
            gesamtsäure_auf.Items.Add("5,8");
            gesamtsäure_auf.Items.Add("6,0");
            gesamtsäure_auf.Items.Add("6,2");
            gesamtsäure_auf.Items.Add("6,4");
            gesamtsäure_auf.Items.Add("6,8");
            gesamtsäure_auf.Items.Add("7,0");
            gesamtsäure_auf.Items.Add("7,2");
            gesamtsäure_auf.Items.Add("7,4");
            gesamtsäure_auf.Items.Add("7,8");
            gesamtsäure_auf.Items.Add("8,0");
            gesamtsäure_auf.Items.Add("8,2");
            gesamtsäure_auf.Items.Add("8,4");
            gesamtsäure_auf.Items.Add("8,8");
            gesamtsäure_auf.Items.Add("9,0");
            gesamtsäure_auf.Items.Add("9,2");
            gesamtsäure_auf.Items.Add("9,4");
            gesamtsäure_auf.Items.Add("9,8");
            gesamtsäure_auf.Items.Add("10,0");
            gesamtsäure_auf.Items.Add("10,2");
            gesamtsäure_auf.Items.Add("10,4");
            gesamtsäure_auf.Items.Add("10,8");
            gesamtsäure_auf.Items.Add("11,0");
            gesamtsäure_auf.Items.Add("11,2");
            gesamtsäure_auf.Items.Add("11,4");
            gesamtsäure_auf.Items.Add("11,8");
            gesamtsäure_auf.Items.Add("12,0");
            gesamtsäure_auf.Items.Add("12,2");
            gesamtsäure_auf.Items.Add("12,4");
            gesamtsäure_auf.Items.Add("12,8");
            gesamtsäure_auf.Items.Add("13,0");
            gesamtsäure_auf.Items.Add("13,2");
            gesamtsäure_auf.Items.Add("13,4");
            gesamtsäure_auf.Items.Add("13,8");
            gesamtsäure_auf.Items.Add("14,0");
            gesamtsäure_auf.Items.Add("14,2");
            gesamtsäure_auf.Items.Add("14,4");
            gesamtsäure_auf.Items.Add("14,8");
            gesamtsäure_auf.Items.Add("15,0");
            gesamtsäure_auf.Items.Add("15,2");
            gesamtsäure_auf.Items.Add("15,4");
            gesamtsäure_auf.Items.Add("15,8");
            gesamtsäure_auf.Items.Add("16,0");
            gesamtsäure_auf.Items.Add("16,2");
            gesamtsäure_auf.Items.Add("16,4");
            gesamtsäure_auf.Items.Add("16,8");
            gesamtsäure_auf.Items.Add("17,0");
            gesamtsäure_auf.Items.Add("17,2");
            gesamtsäure_auf.Items.Add("17,4");
            gesamtsäure_auf.Items.Add("17,8");
            gesamtsäure_auf.Items.Add("18,0");
            gesamtsäure_auf.Items.Add("18,2");
            gesamtsäure_auf.Items.Add("18,4");
            gesamtsäure_auf.Items.Add("18,8");
            gesamtsäure_auf.Items.Add("19,0");
            gesamtsäure_auf.Items.Add("19,2");
            gesamtsäure_auf.Items.Add("19,4");
            gesamtsäure_auf.Items.Add("19,8");
            gesamtsäure_auf.Items.Add("20,0");
            gesamtsäure_auf.SelectedIndex = 0;

            gesamtsäure_in.Items.Add("bitte auswählen");
            gesamtsäure_in.Items.Add("5,2");
            gesamtsäure_in.Items.Add("5,4");
            gesamtsäure_in.Items.Add("5,6");
            gesamtsäure_in.Items.Add("5,8");
            gesamtsäure_in.Items.Add("6,0");
            gesamtsäure_in.Items.Add("6,2");
            gesamtsäure_in.Items.Add("6,4");
            gesamtsäure_in.Items.Add("6,8");
            gesamtsäure_in.Items.Add("7,0");
            gesamtsäure_in.Items.Add("7,2");
            gesamtsäure_in.Items.Add("7,4");
            gesamtsäure_in.Items.Add("7,8");
            gesamtsäure_in.Items.Add("8,0");
            gesamtsäure_in.Items.Add("8,2");
            gesamtsäure_in.Items.Add("8,4");
            gesamtsäure_in.Items.Add("8,8");
            gesamtsäure_in.Items.Add("9,0");
            gesamtsäure_in.Items.Add("9,2");
            gesamtsäure_in.Items.Add("9,4");
            gesamtsäure_in.Items.Add("9,8");
            gesamtsäure_in.Items.Add("10,0");
            gesamtsäure_in.Items.Add("10,2");
            gesamtsäure_in.Items.Add("10,4");
            gesamtsäure_in.Items.Add("10,8");
            gesamtsäure_in.Items.Add("11,0");
            gesamtsäure_in.Items.Add("11,2");
            gesamtsäure_in.Items.Add("11,4");
            gesamtsäure_in.Items.Add("11,8");
            gesamtsäure_in.Items.Add("12,0");
            gesamtsäure_in.Items.Add("12,2");
            gesamtsäure_in.Items.Add("12,4");
            gesamtsäure_in.Items.Add("12,8");
            gesamtsäure_in.Items.Add("13,0");
            gesamtsäure_in.Items.Add("13,2");
            gesamtsäure_in.Items.Add("13,4");
            gesamtsäure_in.Items.Add("13,8");
            gesamtsäure_in.Items.Add("14,0");
            gesamtsäure_in.Items.Add("14,2");
            gesamtsäure_in.Items.Add("14,4");
            gesamtsäure_in.Items.Add("14,8");
            gesamtsäure_in.Items.Add("15,0");
            gesamtsäure_in.Items.Add("15,2");
            gesamtsäure_in.Items.Add("15,4");
            gesamtsäure_in.Items.Add("15,8");
            gesamtsäure_in.Items.Add("16,0");
            gesamtsäure_in.Items.Add("16,2");
            gesamtsäure_in.Items.Add("16,4");
            gesamtsäure_in.Items.Add("16,8");
            gesamtsäure_in.Items.Add("17,0");
            gesamtsäure_in.Items.Add("17,2");
            gesamtsäure_in.Items.Add("17,4");
            gesamtsäure_in.Items.Add("17,8");
            gesamtsäure_in.Items.Add("18,0");
            gesamtsäure_in.Items.Add("18,2");
            gesamtsäure_in.Items.Add("18,4");
            gesamtsäure_in.Items.Add("18,8");
            gesamtsäure_in.Items.Add("19,0");
            gesamtsäure_in.SelectedIndex = 0;

            weinsäure.Items.Add("bitte auswählen");
            weinsäure.Items.Add("1,0");
            weinsäure.Items.Add("1,1");
            weinsäure.Items.Add("1,2");
            weinsäure.Items.Add("1,3");
            weinsäure.Items.Add("1,4");
            weinsäure.Items.Add("1,5");
            weinsäure.Items.Add("1,6");
            weinsäure.Items.Add("1,7");
            weinsäure.Items.Add("1,8");
            weinsäure.Items.Add("1,9");
            weinsäure.Items.Add("2,0");
            weinsäure.Items.Add("2,1");
            weinsäure.Items.Add("2,2");
            weinsäure.Items.Add("2,3");
            weinsäure.Items.Add("2,4");
            weinsäure.Items.Add("2,5");
            weinsäure.Items.Add("2,6");
            weinsäure.Items.Add("2,7");
            weinsäure.Items.Add("2,8");
            weinsäure.Items.Add("2,9");
            weinsäure.Items.Add("3,0");
            weinsäure.Items.Add("3,1");
            weinsäure.Items.Add("3,2");
            weinsäure.Items.Add("3,3");
            weinsäure.Items.Add("3,4");
            weinsäure.Items.Add("3,5");
            weinsäure.Items.Add("3,6");
            weinsäure.Items.Add("3,7");
            weinsäure.Items.Add("3,8");
            weinsäure.Items.Add("3,9");
            weinsäure.Items.Add("4,0");
            weinsäure.Items.Add("4,1");
            weinsäure.Items.Add("4,2");
            weinsäure.Items.Add("4,3");
            weinsäure.Items.Add("4,4");
            weinsäure.Items.Add("4,5");
            weinsäure.Items.Add("4,6");
            weinsäure.Items.Add("4,7");
            weinsäure.Items.Add("4,8");
            weinsäure.Items.Add("4,9");
            weinsäure.Items.Add("5,0");
            weinsäure.Items.Add("5,1");
            weinsäure.Items.Add("5,2");
            weinsäure.Items.Add("5,3");
            weinsäure.Items.Add("5,4");
            weinsäure.Items.Add("5,5");
            weinsäure.Items.Add("5,6");
            weinsäure.Items.Add("5,7");
            weinsäure.Items.Add("5,8");
            weinsäure.Items.Add("5,9");
            weinsäure.Items.Add("6,0");
            weinsäure.Items.Add("6,1");
            weinsäure.Items.Add("6,2");
            weinsäure.Items.Add("6,3");
            weinsäure.Items.Add("6,4");
            weinsäure.Items.Add("6,5");
            weinsäure.Items.Add("6,6");
            weinsäure.Items.Add("6,7");
            weinsäure.Items.Add("6,8");
            weinsäure.Items.Add("6,9");
            weinsäure.Items.Add("7,0");
            weinsäure.Items.Add("7,1");
            weinsäure.Items.Add("7,2");
            weinsäure.Items.Add("7,3");
            weinsäure.Items.Add("7,4");
            weinsäure.Items.Add("7,5");
            weinsäure.Items.Add("7,6");
            weinsäure.Items.Add("7,7");
            weinsäure.Items.Add("7,8");
            weinsäure.Items.Add("7,9");
            weinsäure.Items.Add("8,0");
            weinsäure.Items.Add("8,1");
            weinsäure.Items.Add("8,2");
            weinsäure.Items.Add("8,3");
            weinsäure.Items.Add("8,4");
            weinsäure.Items.Add("8,5");
            weinsäure.Items.Add("8,6");
            weinsäure.Items.Add("8,7");
            weinsäure.Items.Add("8,8");
            weinsäure.Items.Add("8,9");
            weinsäure.Items.Add("9,0");
            weinsäure.Items.Add("9,1");
            weinsäure.Items.Add("9,2");
            weinsäure.Items.Add("9,3");
            weinsäure.Items.Add("9,4");
            weinsäure.Items.Add("9,5");
            weinsäure.Items.Add("9,6");
            weinsäure.Items.Add("9,7");
            weinsäure.Items.Add("9,8");
            weinsäure.Items.Add("9,9");
            weinsäure.Items.Add("10,0");
            weinsäure.SelectedIndex = 0;
        }
        string gs_von_1;

        private void Gesamtsäure_von_SelectedIndexChanged(object sender, EventArgs e)
        {
            gs_von_1 = gesamtsäure_von.Items[gesamtsäure_von.SelectedIndex];
        }
        string gs_auf_1;

        private void Gesamtsäure_auf_SelectedIndexChanged(object sender, EventArgs e)
        {
            gs_auf_1 = gesamtsäure_auf.Items[gesamtsäure_auf.SelectedIndex];
        }
        string gs2_1;
        private void Gesamtsäure_in_SelectedIndexChanged(object sender, EventArgs e)
        {
            gs2_1 = gesamtsäure_in.Items[gesamtsäure_in.SelectedIndex];
        }
        string ws_1;
        private void Weinsäure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ws_1 = weinsäure.Items[weinsäure.SelectedIndex];
        }
        Ergebnis_entsäu ergebnis = new Ergebnis_entsäu();

        void berechnen_Entsäu1(object sender, EventArgs e)
        {

            request_entsäu param = new request_entsäu() { gs_von = gs_von_1, gs_auf = gs_auf_1, em1 = em1.Text };
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();

            String answer;
            String adress = "http://localhost:50088/api/basis_Vs";

            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                double eingabe_user_em1;
                try
                {
                    eingabe_user_em1 = Convert.ToDouble(em1.Text);
                }
                catch
                {
                    DisplayAlert("Hinweis", "Es sind Zahlen einzugeben", "OK");
                    return;
                }
                if (eingabe_user_em1 < 0)
                {
                    DisplayAlert("Hinweis", "Ihre Eingabe muss positiv sein", "OK");
                    return;
                }

                double gs_von_1d = Convert.ToDouble(gs_von_1);

                switch (gs_von_1d)
                {
                    case 5.2:
                        gs_von_1d = 5.2;
                        break;
                    case 5.4:
                        gs_von_1d = 5.4;
                        break;
                    case 5.6:
                        gs_von_1d = 5.6;
                        break;
                    case 5.8:
                        gs_von_1d = 5.8;
                        break;
                    case 6.0:
                        gs_von_1d = 6.0;
                        break;
                    case 6.2:
                        gs_von_1d = 6.2;
                        break;
                    case 6.4:
                        gs_von_1d = 6.4;
                        break;
                    case 6.6:
                        gs_von_1d = 6.6;
                        break;
                    case 6.8:
                        gs_von_1d = 6.8;
                        break;
                    case 7.0:
                        gs_von_1d = 7.0;
                        break;
                    case 7.2:
                        gs_von_1d = 7.2;
                        break;
                    case 7.4:
                        gs_von_1d = 7.4;
                        break;
                    case 7.6:
                        gs_von_1d = 7.6;
                        break;
                    case 7.8:
                        gs_von_1d = 7.8;
                        break;
                    case 8.0:
                        gs_von_1d = 8.0;
                        break;
                    case 8.2:
                        gs_von_1d = 8.2;
                        break;
                    case 8.4:
                        gs_von_1d = 8.4;
                        break;
                    case 8.6:
                        gs_von_1d = 8.6;
                        break;
                    case 8.8:
                        gs_von_1d = 8.8;
                        break;
                    case 9.0:
                        gs_von_1d = 9.0;
                        break;
                    case 9.2:
                        gs_von_1d = 9.2;
                        break;
                    case 9.4:
                        gs_von_1d = 9.4;
                        break;
                    case 9.6:
                        gs_von_1d = 9.6;
                        break;
                    case 9.8:
                        gs_von_1d = 9.8;
                        break;
                    case 10.0:
                        gs_von_1d = 10.0;
                        break;
                    case 10.2:
                        gs_von_1d = 10.2;
                        break;
                    case 10.4:
                        gs_von_1d = 10.4;
                        break;
                    case 10.6:
                        gs_von_1d = 10.6;
                        break;
                    case 10.8:
                        gs_von_1d = 10.8;
                        break;
                    case 11.0:
                        gs_von_1d = 11.0;
                        break;
                    case 11.2:
                        gs_von_1d = 11.2;
                        break;
                    case 11.4:
                        gs_von_1d = 11.4;
                        break;
                    case 11.6:
                        gs_von_1d = 11.6;
                        break;
                    case 11.8:
                        gs_von_1d = 11.8;
                        break;
                    case 12.0:
                        gs_von_1d = 12.0;
                        break;
                    case 12.2:
                        gs_von_1d = 12.2;
                        break;
                    case 12.4:
                        gs_von_1d = 12.4;
                        break;
                    case 12.6:
                        gs_von_1d = 12.6;
                        break;
                    case 12.8:
                        gs_von_1d = 12.8;
                        break;
                    case 13.0:
                        gs_von_1d = 13.0;
                        break;
                    case 13.2:
                        gs_von_1d = 13.2;
                        break;
                    case 13.4:
                        gs_von_1d = 13.4;
                        break;
                    case 13.6:
                        gs_von_1d = 13.6;
                        break;
                    case 13.8:
                        gs_von_1d = 13.8;
                        break;
                    case 14.0:
                        gs_von_1d = 14.0;
                        break;
                    case 14.2:
                        gs_von_1d = 14.2;
                        break;
                    case 14.4:
                        gs_von_1d = 14.4;
                        break;
                    case 14.6:
                        gs_von_1d = 14.6;
                        break;
                    case 14.8:
                        gs_von_1d = 14.8;
                        break;
                    case 15.0:
                        gs_von_1d = 15.0;
                        break;
                    case 15.2:
                        gs_von_1d = 15.2;
                        break;
                    case 15.4:
                        gs_von_1d = 15.4;
                        break;
                    case 15.6:
                        gs_von_1d =15.6;
                        break;
                    case 15.8:
                        gs_von_1d = 15.8;
                        break;
                    case 16.0:
                        gs_von_1d = 16.0;
                        break;
                    case 16.2:
                        gs_von_1d = 16.2;
                        break;
                    case 16.4:
                        gs_von_1d = 16.4;
                        break;
                    case 16.6:
                        gs_von_1d = 16.6;
                        break;
                    case 16.8:
                        gs_von_1d = 16.8;
                        break;
                    case 17.0:
                        gs_von_1d = 17.0;
                        break;
                    case 17.2:
                        gs_von_1d = 17.2;
                        break;
                    case 17.4:
                        gs_von_1d = 17.4;
                        break;
                    case 17.6:
                        gs_von_1d = 17.6;
                        break;
                    case 17.8:
                        gs_von_1d = 17.8;
                        break;
                    case 18.0:
                        gs_von_1d = 18.0;
                        break;
                    case 18.2:
                        gs_von_1d = 18.2;
                        break;
                    case 18.4:
                        gs_von_1d = 18.4;
                        break;
                    case 18.6:
                        gs_von_1d = 18.6;
                        break;
                    case 18.8:
                        gs_von_1d = 18.8;
                        break;
                    case 19.0:
                        gs_von_1d = 19.0;
                        break;
                    case 19.2:
                        gs_von_1d = 19.2;
                        break;
                    case 19.4:
                        gs_von_1d = 19.4;
                        break;
                    case 19.6:
                        gs_von_1d = 19.6;
                        break;
                    case 19.8:
                        gs_von_1d = 19.8;
                        break;
                    case 20.0:
                        gs_von_1d = 20.0;
                        break;
                   
                }
                
                double gs_auf_1d = Convert.ToDouble(gs_auf_1);
                switch (gs_auf_1d)
                {
                    case 5.2:
                        gs_auf_1d = 5.2;
                        break;
                    case 5.4:
                        gs_auf_1d = 5.4;
                        break;
                    case 5.6:
                        gs_auf_1d = 5.6;
                        break;
                    case 5.8:
                        gs_auf_1d = 5.8;
                        break;
                    case 6.0:
                        gs_auf_1d = 6.0;
                        break;
                    case 6.2:
                        gs_auf_1d = 6.2;
                        break;
                    case 6.4:
                        gs_auf_1d = 6.4;
                        break;
                    case 6.6:
                        gs_auf_1d = 6.6;
                        break;
                    case 6.8:
                        gs_auf_1d = 6.8;
                        break;
                    case 7.0:
                        gs_auf_1d = 7.0;
                        break;
                    case 7.2:
                        gs_auf_1d = 7.2;
                        break;
                    case 7.4:
                        gs_auf_1d = 7.4;
                        break;
                    case 7.6:
                        gs_auf_1d = 7.6;
                        break;
                    case 7.8:
                        gs_auf_1d = 7.8;
                        break;
                    case 8.0:
                        gs_auf_1d = 8.0;
                        break;
                    case 8.2:
                        gs_auf_1d = 8.2;
                        break;
                    case 8.4:
                        gs_auf_1d = 8.4;
                        break;
                    case 8.6:
                        gs_auf_1d = 8.6;
                        break;
                    case 8.8:
                        gs_auf_1d = 8.8;
                        break;
                    case 9.0:
                        gs_auf_1d = 9.0;
                        break;
                    case 9.2:
                        gs_auf_1d = 9.2;
                        break;
                    case 9.4:
                        gs_auf_1d = 9.4;
                        break;
                    case 9.6:
                        gs_auf_1d = 9.6;
                        break;
                    case 9.8:
                        gs_auf_1d = 9.8;
                        break;
                    case 10.0:
                        gs_auf_1d = 10.0;
                        break;
                    case 10.2:
                        gs_auf_1d = 10.2;
                        break;
                    case 10.4:
                        gs_auf_1d = 10.4;
                        break;
                    case 10.6:
                        gs_auf_1d = 10.6;
                        break;
                    case 10.8:
                        gs_auf_1d = 10.8;
                        break;
                    case 11.0:
                        gs_auf_1d = 11.0;
                        break;
                    case 11.2:
                        gs_auf_1d = 11.2;
                        break;
                    case 11.4:
                        gs_auf_1d = 11.4;
                        break;
                    case 11.6:
                        gs_auf_1d = 11.6;
                        break;
                    case 11.8:
                        gs_auf_1d = 11.8;
                        break;
                    case 12.0:
                        gs_auf_1d = 12.0;
                        break;
                    case 12.2:
                        gs_auf_1d = 12.2;
                        break;
                    case 12.4:
                        gs_auf_1d = 12.4;
                        break;
                    case 12.6:
                        gs_auf_1d = 12.6;
                        break;
                    case 12.8:
                        gs_auf_1d = 12.8;
                        break;
                    case 13.0:
                        gs_auf_1d = 13.0;
                        break;
                    case 13.2:
                        gs_auf_1d = 13.2;
                        break;
                    case 13.4:
                        gs_auf_1d = 13.4;
                        break;
                    case 13.6:
                        gs_auf_1d = 13.6;
                        break;
                    case 13.8:
                        gs_auf_1d = 13.8;
                        break;
                    case 14.0:
                        gs_auf_1d = 14.0;
                        break;
                    case 14.2:
                        gs_auf_1d = 14.2;
                        break;
                    case 14.4:
                        gs_auf_1d = 14.4;
                        break;
                    case 14.6:
                        gs_auf_1d = 14.6;
                        break;
                    case 14.8:
                        gs_auf_1d = 14.8;
                        break;
                    case 15.0:
                        gs_auf_1d = 15.0;
                        break;
                    case 15.2:
                        gs_auf_1d = 15.2;
                        break;
                    case 15.4:
                        gs_auf_1d = 15.4;
                        break;
                    case 15.6:
                        gs_auf_1d = 15.6;
                        break;
                    case 15.8:
                        gs_auf_1d = 15.8;
                        break;
                    case 16.0:
                        gs_auf_1d = 16.0;
                        break;
                    case 16.2:
                        gs_auf_1d = 16.2;
                        break;
                    case 16.4:
                        gs_auf_1d = 16.4;
                        break;
                    case 16.6:
                        gs_auf_1d = 16.6;
                        break;
                    case 16.8:
                        gs_auf_1d = 16.8;
                        break;
                    case 17.0:
                        gs_auf_1d = 17.0;
                        break;
                    case 17.2:
                        gs_auf_1d = 17.2;
                        break;
                    case 17.4:
                        gs_auf_1d = 17.4;
                        break;
                    case 17.6:
                        gs_auf_1d = 17.6;
                        break;
                    case 17.8:
                        gs_auf_1d = 17.8;
                        break;
                    case 18.0:
                        gs_auf_1d = 18.0;
                        break;
                    case 18.2:
                        gs_auf_1d = 18.2;
                        break;
                    case 18.4:
                        gs_auf_1d = 18.4;
                        break;
                    case 18.6:
                        gs_auf_1d = 18.6;
                        break;
                    case 18.8:
                        gs_auf_1d = 18.8;
                        break;
                    case 19.0:
                        gs_auf_1d = 19.0;
                        break;
                    case 19.2:
                        gs_auf_1d = 19.2;
                        break;
                    case 19.4:
                        gs_auf_1d = 19.4;
                        break;
                    case 19.6:
                        gs_auf_1d = 19.6;
                        break;
                    case 19.8:
                        gs_auf_1d = 19.8;
                        break;
                    case 20.0:
                        gs_auf_1d = 20.0;
                        break;
                }
                


                //Ergebnisse berechnnen
                double e1 = gs_von_1d - gs_auf_1d;
                double e2 = (Convert.ToDouble(em1.Text) / 100.0) * (67.0 / 1000.0) * e1;

                //Ausgabe Ergebnisse
                ergebnis.menge_ent1 = e2;
                ergebnis.um = e1;
            }
            else
            {
                EntsäuRestResponse erg = new EntsäuRestResponse() { };
                erg = JsonConvert.DeserializeObject<EntsäuRestResponse>(answer);
                if (erg.EventStatus != 0)
                {
                    DisplayAlert("Hinweis", erg.EventMessage, "OK");

                    return;
                }
                ergebnis.menge_ent1 = erg.menge_ent1;
                ergebnis.um = erg.um;

            }
            NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Entsäu(ergebnis)) { BarBackgroundColor = Color.DarkRed };
            Navigation.PushAsync(nav);
        }
        void berechnen_Entsäu2(object sender, EventArgs e)
        {

            request_entsäu param = new request_entsäu() { gs2 = gs2_1, ws = ws_1, em2 = em2.Text, ent_um = ent_um.Text };
            String request = JsonConvert.SerializeObject(param);
            RESTConnector rconn = new RESTConnector();

            String answer;
            String adress = "http://localhost:50088/api/basis_Vs";

            answer = rconn.HTTP_POST(adress, request, 5, false);
            if (answer.Contains("REST_HTTP_ERROR"))
            {
                double eingabe_user_em2;
                try
                {
                    eingabe_user_em2 = Convert.ToDouble(em2.Text);
                }
                catch
                {
                    DisplayAlert("Hinweis", "Es sind Zahlen einzugeben", "OK");
                    return;
                }
                if (eingabe_user_em2 < 0)
                {
                    DisplayAlert("Hinweis", "Ihre Eingabe muss positiv sein", "OK");
                    return;
                }
                // Exception für ent_um einfügen



                double gs2_1d = Convert.ToDouble(gs2_1);
                switch (gs2_1d)
                {
                    case 5.2:
                        gs2_1d = 5.2;
                        break;
                    case 5.4:
                        gs2_1d = 5.4;
                        break;
                    case 5.6:
                        gs2_1d = 5.6;
                        break;
                    case 5.8:
                        gs2_1d = 5.8;
                        break;
                    case 6.0:
                        gs2_1d = 6.0;
                        break;
                    case 6.2:
                        gs2_1d = 6.2;
                        break;
                    case 6.4:
                        gs2_1d = 6.4;
                        break;
                    case 6.6:
                        gs2_1d = 6.6;
                        break;
                    case 6.8:
                        gs2_1d = 6.8;
                        break;
                    case 7.0:
                        gs2_1d = 7.0;
                        break;
                    case 7.2:
                        gs2_1d = 7.2;
                        break;
                    case 7.4:
                        gs2_1d = 7.4;
                        break;
                    case 7.6:
                        gs2_1d = 7.6;
                        break;
                    case 7.8:
                        gs2_1d = 7.8;
                        break;
                    case 8.0:
                        gs2_1d = 8.0;
                        break;
                    case 8.2:
                        gs2_1d = 8.2;
                        break;
                    case 8.4:
                        gs2_1d = 8.4;
                        break;
                    case 8.6:
                        gs2_1d = 8.6;
                        break;
                    case 8.8:
                        gs2_1d = 8.8;
                        break;
                    case 9.0:
                        gs2_1d = 9.0;
                        break;
                    case 9.2:
                        gs2_1d = 9.2;
                        break;
                    case 9.4:
                        gs2_1d = 9.4;
                        break;
                    case 9.6:
                        gs2_1d = 9.6;
                        break;
                    case 9.8:
                        gs2_1d = 9.8;
                        break;
                    case 10.0:
                        gs2_1d = 10.0;
                        break;
                    case 10.2:
                        gs2_1d = 10.2;
                        break;
                    case 10.4:
                        gs2_1d = 10.4;
                        break;
                    case 10.6:
                        gs2_1d = 10.6;
                        break;
                    case 10.8:
                        gs2_1d = 10.8;
                        break;
                    case 11.0:
                        gs2_1d = 11.0;
                        break;
                    case 11.2:
                        gs2_1d = 11.2;
                        break;
                    case 11.4:
                        gs2_1d = 11.4;
                        break;
                    case 11.6:
                        gs2_1d = 11.6;
                        break;
                    case 11.8:
                        gs2_1d = 11.8;
                        break;
                    case 12.0:
                        gs2_1d = 12.0;
                        break;
                    case 12.2:
                        gs2_1d = 12.2;
                        break;
                    case 12.4:
                        gs2_1d = 12.4;
                        break;
                    case 12.6:
                        gs2_1d = 12.6;
                        break;
                    case 12.8:
                        gs2_1d = 12.8;
                        break;
                    case 13.0:
                        gs2_1d = 13.0;
                        break;
                    case 13.2:
                        gs2_1d = 13.2;
                        break;
                    case 13.4:
                        gs2_1d = 13.4;
                        break;
                    case 13.6:
                        gs2_1d = 13.6;
                        break;
                    case 13.8:
                        gs2_1d = 13.8;
                        break;
                    case 14.0:
                        gs2_1d = 14.0;
                        break;
                    case 14.2:
                        gs2_1d = 14.2;
                        break;
                    case 14.4:
                        gs2_1d = 14.4;
                        break;
                    case 14.6:
                        gs2_1d = 14.6;
                        break;
                    case 14.8:
                        gs2_1d = 14.8;
                        break;
                    case 15.0:
                        gs2_1d = 15.0;
                        break;
                    case 15.2:
                        gs2_1d = 15.2;
                        break;
                    case 15.4:
                        gs2_1d = 15.4;
                        break;
                    case 15.6:
                        gs2_1d = 15.6;
                        break;
                    case 15.8:
                        gs2_1d = 15.8;
                        break;
                    case 16.0:
                        gs2_1d = 16.0;
                        break;
                    case 16.2:
                        gs2_1d = 16.2;
                        break;
                    case 16.4:
                        gs2_1d = 16.4;
                        break;
                    case 16.6:
                        gs2_1d = 16.6;
                        break;
                    case 16.8:
                        gs2_1d = 16.8;
                        break;
                    case 17.0:
                        gs2_1d = 17.0;
                        break;
                    case 17.2:
                        gs2_1d = 17.2;
                        break;
                    case 17.4:
                        gs2_1d = 17.4;
                        break;
                    case 17.6:
                        gs2_1d = 17.6;
                        break;
                    case 17.8:
                        gs2_1d = 17.8;
                        break;
                    case 18.0:
                        gs2_1d = 18.0;
                        break;
                    case 18.2:
                        gs2_1d = 18.2;
                        break;
                    case 18.4:
                        gs2_1d = 18.4;
                        break;
                    case 18.6:
                        gs2_1d = 18.6;
                        break;
                    case 18.8:
                        gs2_1d = 18.8;
                        break;
                    case 19.0:
                        gs2_1d = 19.0;
                        break;
                    case 19.2:
                        gs2_1d = 19.2;
                        break;
                    case 19.4:
                        gs2_1d = 19.4;
                        break;
                    case 19.6:
                        gs2_1d = 19.6;
                        break;
                    case 19.8:
                        gs2_1d = 19.8;
                        break;
                    case 20.0:
                        gs2_1d = 20.0;
                        break;
                }
                
                double ws_1d = Convert.ToDouble(ws_1);
                switch (ws_1d)
                {
                    case 1.0:
                        ws_1d = 1.0;
                        break;
                    case 1.1:
                        ws_1d = 1.1;
                        break;
                    case 1.2:
                        ws_1d = 1.2;
                        break;
                    case 1.3:
                        ws_1d = 1.3;
                        break;
                    case 1.4:
                        ws_1d = 1.4;
                        break;
                    case 1.5:
                        ws_1d = 1.5;
                        break;
                    case 1.6:
                        ws_1d = 1.6;
                        break;
                    case 1.7:
                        ws_1d = 1.7;
                        break;
                    case 1.8:
                        ws_1d = 1.8;
                        break;
                    case 1.9:
                        ws_1d = 1.9;
                        break;
                    case 2.0:
                        ws_1d = 2.0;
                        break;
                    case 2.1:
                        ws_1d = 2.1;
                        break;
                    case 2.2:
                        ws_1d = 2.2;
                        break;
                    case 2.3:
                        ws_1d = 2.3;
                        break;
                    case 2.4:
                        ws_1d = 2.4;
                        break;
                    case 2.5:
                        ws_1d = 2.5;
                        break;
                    case 2.6:
                        ws_1d = 2.6;
                        break;
                    case 2.7:
                        ws_1d = 2.7;
                        break;
                    case 2.8:
                        ws_1d = 2.8;
                        break;
                    case 2.9:
                        ws_1d = 2.9;
                        break;
                    case 3.0:
                        ws_1d = 3.0;
                        break;
                    case 3.1:
                        ws_1d = 3.1;
                        break;
                    case 3.2:
                        ws_1d = 3.2;
                        break;
                    case 3.3:
                        ws_1d = 3.3;
                        break;
                    case 3.4:
                        ws_1d = 3.4;
                        break;
                    case 3.5:
                        ws_1d = 3.5;
                        break;
                    case 3.6:
                        ws_1d = 3.6;
                        break;
                    case 3.7:
                        ws_1d = 3.7;
                        break;
                    case 3.8:
                        ws_1d = 3.8;
                        break;
                    case 3.9:
                        ws_1d = 3.9;
                        break;
                    case 4.0:
                        ws_1d = 4.0;
                        break;
                    case 4.1:
                        ws_1d = 4.1;
                        break;
                    case 4.2:
                        ws_1d = 4.2;
                        break;
                    case 4.3:
                        ws_1d = 4.3;
                        break;
                    case 4.4:
                        ws_1d = 4.4;
                        break;
                    case 4.5:
                        ws_1d = 4.5;
                        break;
                    case 4.6:
                        ws_1d = 4.6;
                        break;
                    case 4.7:
                        ws_1d = 4.7;
                        break;
                    case 4.8:
                        ws_1d = 4.8;
                        break;
                    case 4.9:
                        ws_1d = 4.9;
                        break;
                    case 5.0:
                        ws_1d = 5.0;
                        break;
                    case 5.1:
                        ws_1d = 5.1;
                        break;
                    case 5.2:
                        ws_1d = 5.2;
                        break;
                    case 5.3:
                        ws_1d = 5.3;
                        break;
                    case 5.4:
                        ws_1d = 5.4;
                        break;
                    case 5.5:
                        ws_1d = 5.5;
                        break;
                    case 5.6:
                        ws_1d = 5.6;
                        break;
                    case 5.7:
                        ws_1d = 5.7;
                        break;
                    case 5.8:
                        ws_1d = 5.8;
                        break;
                    case 5.9:
                        ws_1d = 5.9;
                        break;
                    case 6.0:
                        ws_1d = 6.0;
                        break;
                    case 6.1:
                        ws_1d = 6.1;
                        break;
                    case 6.2:
                        ws_1d = 6.2;
                        break;
                    case 6.3:
                        ws_1d = 6.3;
                        break;
                    case 6.4:
                        ws_1d = 6.4;
                        break;
                    case 6.5:
                        ws_1d = 6.5;
                        break;
                    case 6.6:
                        ws_1d = 6.6;
                        break;
                    case 6.7:
                        ws_1d = 6.7;
                        break;
                    case 6.8:
                        ws_1d = 6.8;
                        break;
                    case 6.9:
                        ws_1d = 6.9;
                        break;
                    case 7.0:
                        ws_1d = 7.0;
                        break;
                    case 7.1:
                        ws_1d = 7.1;
                        break;
                    case 7.2:
                        ws_1d = 7.2;
                        break;
                    case 7.3:
                        ws_1d = 7.3;
                        break;
                    case 7.4:
                        ws_1d = 7.4;
                        break;
                    case 7.5:
                        ws_1d = 7.5;
                        break;
                    case 7.6:
                        ws_1d = 7.6;
                        break;
                    case 7.7:
                        ws_1d = 7.7;
                        break;
                    case 7.8:
                        ws_1d = 7.8;
                        break;
                    case 7.9:
                        ws_1d = 7.9;
                        break;
                    case 8.0:
                        ws_1d = 8.0;
                        break;
                    case 8.1:
                        ws_1d = 8.1;
                        break;
                    case 8.2:
                        ws_1d = 8.2;
                        break;
                    case 8.3:
                        ws_1d = 8.3;
                        break;
                    case 8.4:
                        ws_1d = 8.4;
                        break;
                    case 8.5:
                        ws_1d = 8.5;
                        break;
                    case 8.6:
                        ws_1d = 8.6;
                        break;
                    case 8.7:
                        ws_1d = 8.7;
                        break;
                    case 8.8:
                        ws_1d = 8.8;
                        break;
                    case 8.9:
                        ws_1d = 8.9;
                        break;
                    case 9.0:
                        ws_1d = 9.0;
                        break;
                    case 9.1:
                        ws_1d = 9.1;
                        break;
                    case 9.2:
                        ws_1d = 9.2;
                        break;
                    case 9.3:
                        ws_1d = 9.3;
                        break;
                    case 9.4:
                        ws_1d = 9.4;
                        break;
                    case 9.5:
                        ws_1d = 9.5;
                        break;
                    case 9.6:
                        ws_1d = 9.6;
                        break;
                    case 9.7:
                        ws_1d = 9.7;
                        break;
                    case 9.8:
                        ws_1d = 9.8;
                        break;
                    case 9.9:
                        ws_1d = 9.9;
                        break;
                    case 10.0:
                        ws_1d = 10.0;
                        break;
                }
                //Picker implementieren von 1,0 bis 10,0 in 0,1 Schritten

                //ergebnisse berechnen
                double e3 = gs2_1d * (ws_1d - 0.5) / (gs2_1d - ws_1d);                      //E1
                double e4 = gs2_1d - Convert.ToDouble(ent_um.Text);                         //E5
                double e5 = ((gs2_1d - e4) * Convert.ToDouble(em2.Text) * 0.67) / 1000;     //E2
                double e6 = Convert.ToDouble(em2.Text) * ((gs2_1d - e4) / (gs2_1d - 2));    //E3
                double e7 = Convert.ToDouble(em2.Text) * ((gs2_1d - e4) / (gs2_1d - 3));    //E4

                //Ausgabe Ergebnisse
                ergebnis.ent_spanne = e3;
                ergebnis.menge_ent2 = e5;
                ergebnis.most_ent = Convert.ToInt32(e6);
                ergebnis.wein_ent = Convert.ToInt32(e7);
                ergebnis.auf = e4;

            }
            else
            {
                EntsäuRestResponse erg = new EntsäuRestResponse() { };
                erg = JsonConvert.DeserializeObject<EntsäuRestResponse>(answer);
                if (erg.EventStatus != 0)
                {
                    DisplayAlert("Hinweis", erg.EventMessage, "OK");

                    return;
                }
                ergebnis.ent_spanne = erg.ent_spanne;
                ergebnis.menge_ent2 = erg.menge_ent2;
                ergebnis.most_ent = erg.most_ent;
                ergebnis.wein_ent = erg.wein_ent;
                ergebnis.auf = erg.auf;

            }
            NavigationPage nav = new NavigationPage(new Ergebnis_Rechnung_Entsäu(ergebnis)) { BarBackgroundColor = Color.DarkRed };
            Navigation.PushAsync(nav);
        }


    }
}