using ReBook.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReBook.Data;
using System.IO;


namespace ReBook
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Books.db";
        internal static DataAccess db;
        internal static DataAccess Db
        {
            get
            {
                if (db == null)
                {
                    db = new DataAccess(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();
            if(Db.GetBooks().Count == 0)
            {
                Deserialize.Main();
            }

            MainPage = new NavigationPage(new BooksCatalogPage());
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
