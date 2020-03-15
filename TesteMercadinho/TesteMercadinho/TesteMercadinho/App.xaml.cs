using System;
using TesteMercadinho.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesteMercadinho
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PagePrincipal();
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
