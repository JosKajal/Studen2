using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Studen2.Vistas;

namespace Studen2
{
    public partial class MainPage : ContentPage
    {
        Pestañas pestañas = new Pestañas();
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(pestañas, true);
        }
    }
}
