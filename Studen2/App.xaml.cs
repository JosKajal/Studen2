using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Studen2.Vistas;
namespace Studen2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage (new MainPage());
            //MainPage = new MainPage(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
