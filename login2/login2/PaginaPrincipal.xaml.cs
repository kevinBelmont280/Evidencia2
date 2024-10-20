using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace login2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Inicio Correcta", "Bienvenido", "salir");

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Vamos a registarte", "Bienvenido", "salir");

        }
    }
}
