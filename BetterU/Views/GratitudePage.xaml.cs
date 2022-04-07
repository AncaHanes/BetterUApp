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
    public partial class GratitudePage : ContentPage
    {
        public GratitudePage()
        {
            InitializeComponent();
        }

        private void BtnDone_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}