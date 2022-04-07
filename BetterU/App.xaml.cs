
using BetterU.Data;
using BetterU.Views;
using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BetterU
{
    public partial class App : Application
    {
        private static MobileDatabase database;
        public static MobileDatabase Database
        {
            get
            {
                if (database == null)
                {

                    database = new MobileDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDatabase.db"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            

            MainPage = new NavigationPage(new LoginPage());
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
