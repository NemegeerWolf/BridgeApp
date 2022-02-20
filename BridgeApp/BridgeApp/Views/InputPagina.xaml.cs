using BridgeApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BridgeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InputPagina : ContentPage
    {
        public InputPagina()
        {
            InitializeComponent();
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            try
            {
                List<string[]> list_of_arr_scores = new List<string[]>();
                int row = 6;
                int column = 0;
                if (Convert.ToInt32(pkAantal.SelectedItem) <= Convert.ToInt32(pkBehaald.SelectedItem))
                {
                    if (swKwetsbaar.IsToggled)
                    {
                        list_of_arr_scores = BlobManuplator.ReadcsvToArray<string>("Assets/Scores_kwetsbaar.csv");
                    }
                    else
                    {
                        list_of_arr_scores = BlobManuplator.ReadcsvToArray<string>("Assets/Scores_niet_kwetsbaar.csv");
                    }
                    if (pkTroef.SelectedIndex == 0)
                    {


                    }
                    else if (pkTroef.SelectedIndex <= 2)
                    {
                        row += 26;
                    }
                    else if (pkTroef.SelectedIndex <= 5)
                    {
                        row += 2 * 26;
                    }
                    if (rdbtnDouble.IsChecked)
                    {
                        row += 7;
                    }
                    else if (rdbtnRedouble.IsChecked)
                    {
                        row += 14;
                    }
                    row += Convert.ToInt32(pkBehaald.SelectedItem) - Convert.ToInt32(pkAantal.SelectedItem);
                    column = Convert.ToInt32(pkAantal.SelectedItem);

                }
                else
                {
                    list_of_arr_scores = BlobManuplator.ReadcsvToArray<string>("Assets/MinPunten.csv");
                    row = 0;
                    if (swKwetsbaar.IsToggled)
                    {
                        row = 3;
                    }
                    if (rdbtnDouble.IsChecked)
                    {
                        row += 1;
                    }
                    else if (rdbtnRedouble.IsChecked)
                    {
                        row += 2;
                    }
                    column = Convert.ToInt32(pkAantal.SelectedItem) - Convert.ToInt32(pkBehaald.SelectedItem);

                }

                Debug.WriteLine(list_of_arr_scores[row][column]);

                Navigation.PushAsync(new ResultaatPagina(Convert.ToInt32( list_of_arr_scores[row][column]), rdbtnNZ.IsChecked));
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
    }
}