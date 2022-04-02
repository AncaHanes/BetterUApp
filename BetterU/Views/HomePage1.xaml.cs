using BetterU;
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
    public partial class HomePage1 : ContentPage
    {
        public HomePage1()
        {
            InitializeComponent();
            selectionView.ItemsSource = new[]
             {
                "Eat healthy ", "Sleep better","Study","Hit the gym","Meditate","Read","Self-esteem","Relationships"
             };
        }

        /*
        async void ButtonLogout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        */
        async void ButtonStart_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }
    }
}
