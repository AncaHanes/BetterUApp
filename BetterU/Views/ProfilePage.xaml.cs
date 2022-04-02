﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BetterU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        async void ButtonLogout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void ButtonAboutUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }
        async void ButtonContactUs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactUsPage());
        }
        async void ButtonProgress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgressPage());
        }
        async void ButtonChangePass_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangePasswordPage());
        }
    }
}