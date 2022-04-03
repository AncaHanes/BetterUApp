using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using BetterU.Tables;
using Xamarin.Essentials;

namespace BetterU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                Username = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text

            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulations", "User Registration Successful", "OK", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginPage());
            });
            Preferences.Set("username", EntryUserName.Text);
        }
    }
}