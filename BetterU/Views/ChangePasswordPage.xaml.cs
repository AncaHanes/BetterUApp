﻿using BetterU.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BetterU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePasswordPage : ContentPage
    {
        public ChangePasswordPage()
        {
            InitializeComponent();
        }
        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        async void ButtonSaveChanges_Clicked(object sender, EventArgs e)
        {
            var currentPassword = Preferences.Get("password", string.Empty);
            var pass = new RegUserTable();
            if(EntryPass1.Text != currentPassword)
            {
                var newPassword = EntryPass1.Text;
                if (EntryPass1.Text == EntryPass2.Text)
                {
                    pass.Password = newPassword;
                    await App.Database.SavePassAsync(pass);
                    _ = DisplayAlert("", "Your password was changed with success!", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("", "Your passwords don't match!", "Cancel");
                }
            }
            else
            {
                await DisplayAlert("", "Find a new password different from current one.", "Cancel");
            }
           
            
        }
    }
}