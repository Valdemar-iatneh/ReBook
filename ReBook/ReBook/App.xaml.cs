using ReBook.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReBook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegPage();
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
