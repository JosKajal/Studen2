using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Studen2.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pestañas : ContentPage
    {
        public Pestañas()
        {
            InitializeComponent();            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.DisplayAlert("Comentario",ComEntry.Text, "Detener");
            Navigation.PushAsync(mainPage, true);
        }
    }
}