using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpenafielS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Habilitando navegacion entre pantallas
            MainPage = new NavigationPage(new Inicio());
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
