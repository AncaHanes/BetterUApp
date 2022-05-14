using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BetterU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressPage : ContentPage
    {
        public ProgressPage()
        {
            InitializeComponent();
        }
        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        async void ButtonWellbeing_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WellbeingPage());
        }
    }
}