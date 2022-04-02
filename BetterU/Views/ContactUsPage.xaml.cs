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
    public partial class ContactUsPage : ContentPage
    {
        public ContactUsPage()
        {
            InitializeComponent();
        }
        private void BtnCall_Clicked(object sender, EventArgs e)
        {
            PhoneDialer.Open("0744582615");
        }
        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}