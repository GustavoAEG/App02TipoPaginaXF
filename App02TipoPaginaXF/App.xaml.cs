using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;


namespace App02TipoPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new TipoPagina.Carousel.IntroducaoApp();


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
