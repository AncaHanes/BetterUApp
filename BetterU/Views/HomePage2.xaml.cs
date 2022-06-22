using BetterU.Tables;
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
    public partial class HomePage2 : ContentPage
    {
        public HomePage2()
        {
            InitializeComponent();
        }
      
        private void ImageButton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new GratitudePage());
        }

        async void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
              
            int x;
            if(radio1.IsChecked)
            {
                x = 1;
                var obs = new Moods();
                obs.Value = x;
                obs.Date = DateTime.Today;
               // label.Text = obs.Value.ToString();
                await App.Database.SaveMoodsAsync(obs);
            }
            if (radio2.IsChecked)
            {
                x = 2;
                var obs = new Moods();
                obs.Value = x;
                obs.Date = DateTime.Today;
                // label.Text = obs.Value.ToString();
                await App.Database.SaveMoodsAsync(obs);
            }
            if (radio3.IsChecked)
            {
                x = 3;
                var obs = new Moods();
                obs.Value = x;
                obs.Date = DateTime.Today;
                // label.Text = obs.Value.ToString();
                await App.Database.SaveMoodsAsync(obs);
            }
            if (radio4.IsChecked)
            {
                x = 4;
                var obs = new Moods();
                obs.Value = x;
                obs.Date = DateTime.Today;
                // label.Text = obs.Value.ToString();
                await App.Database.SaveMoodsAsync(obs);
            }
            if (radio5.IsChecked)
            {
                x = 5;
                var obs = new Moods();
                obs.Value = x;
                obs.Date = DateTime.Today;
                // label.Text = obs.Value.ToString();
                await App.Database.SaveMoodsAsync(obs);
                label.Text = obs.Value.ToString();
            }
           
        }
        
       
    }
}