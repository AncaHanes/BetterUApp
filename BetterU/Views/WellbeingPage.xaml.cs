﻿using BetterU.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BetterU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WellbeingPage : ContentPage
    {
       
        public WellbeingPage()
        {
            InitializeComponent();
            
        }
        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        /*
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView1.ItemsSource = await App.Database.GetCountVBAsync();

           
        }
        */
    }
}