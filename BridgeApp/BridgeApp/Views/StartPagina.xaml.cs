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
    public partial class StartPagina : ContentPage
    {
        public static int ScoreNoordZuid = 0;
        public static int ScoreOostWest = 0;
        public static bool puntenAanTegenstander = false;

        public static List<int> puntenNoordZuid = new List<int>();
        public static List<int> puntenOostWest = new List<int>();

        public StartPagina()
        {
            InitializeComponent();
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            puntenAanTegenstander = (bool)swPuntenAanTegenstander.IsToggled;
            Navigation.PushAsync(new InputPagina());
        }
    }
}