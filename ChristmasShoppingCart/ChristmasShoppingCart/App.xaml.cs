using ChristmasShoppingCart.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChristmasShoppingCart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DetailView();
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
