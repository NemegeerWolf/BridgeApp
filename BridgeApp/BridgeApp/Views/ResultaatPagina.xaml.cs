using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BridgeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultaatPagina : ContentPage
    {
        private int Punten;
        private bool N_Z;


        public ResultaatPagina(int punten, bool n_z)
        {
            InitializeComponent();
            this.Punten = punten;
            this.N_Z = n_z;


            if (n_z)
            {
                if (punten < 0 && StartPagina.puntenAanTegenstander)
                {
                    StartPagina.puntenNoordZuid.Add(0);
                    StartPagina.puntenOostWest.Add(punten * -1);
                    StartPagina.ScoreOostWest += punten * -1;
                    lblScoreOost_West.Text = StartPagina.ScoreOostWest.ToString();
                }
                else
                {
                    StartPagina.puntenNoordZuid.Add(punten);
                    StartPagina.puntenOostWest.Add(0);
                    StartPagina.ScoreNoordZuid += punten;
                }

                
            }
            else
            {
                if (punten < 0 && StartPagina.puntenAanTegenstander)
                {
                    StartPagina.puntenOostWest.Add(0);
                    StartPagina.puntenNoordZuid.Add(punten * -1);
                    StartPagina.ScoreNoordZuid += punten * -1;
                    
                }
                else
                {
                    StartPagina.puntenOostWest.Add(punten);
                    StartPagina.puntenNoordZuid.Add(0);
                    StartPagina.ScoreOostWest += punten;
                }
            }
            lstvPuntenNoord_Zuid.ItemsSource = StartPagina.puntenNoordZuid;
            lstvPuntenOost_West.ItemsSource = StartPagina.puntenOostWest;
            lblScoreOost_West.Text = StartPagina.ScoreOostWest.ToString();
            lblScoreNoord_Zuid.Text = StartPagina.ScoreNoordZuid.ToString();
            //lblPreScoreNoord_Zuid.Text = StartPagina.ScoreNoordZuid.ToString();
            //lblPreScoreOost_West.Text = StartPagina.ScoreOostWest.ToString();
            //    if (n_z)
            //    {

            //        //lblPuntenNoord_Zuid.Text = punten.ToString();
            //        StartPagina.ScoreNoordZuid += punten;
            //        lblScoreNoord_Zuid.Text = StartPagina.ScoreNoordZuid.ToString();
            //        if(punten < 0 && StartPagina.puntenAanTegenstander)
            //        {
            //            //lblPuntenOost_West.Text = (punten * -1).ToString();
            //            StartPagina.ScoreOostWest += punten * -1;
            //            lblScoreOost_West.Text = StartPagina.ScoreOostWest.ToString();
            //        }
            //        else
            //        {

            //        }
            //    }
            //    else
            //    {
            //        //lblPuntenOost_West.Text = punten.ToString();
            //        StartPagina.ScoreOostWest += punten;
            //        lblScoreOost_West.Text = StartPagina.ScoreOostWest.ToString();
            //        if (punten < 0 && StartPagina.puntenAanTegenstander)
            //        {
            //            //lblPuntenNoord_Zuid.Text = (punten * -1).ToString();
            //            StartPagina.ScoreNoordZuid += punten * -1;
            //            lblScoreNoord_Zuid.Text = StartPagina.ScoreNoordZuid.ToString();
            //        }
            //    }
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}