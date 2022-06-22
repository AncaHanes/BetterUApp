using BetterU.Tables;
using Plugin.LocalNotification;
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
    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
        }
        private void TapBack_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if(isRepeatbutton.IsChecked)
            {
                isRepeatbutton.IsChecked = true;
                await App.Database.SaveNotifAsync(new Notifications
                {

                    Hour = _timePicker.Time,
                    isRepeatChecked = true

                }); 
            }
            else
            {
                await App.Database.SaveNotifAsync(new Notifications
                {

                    Hour = _timePicker.Time,
                    isRepeatChecked = false

                });
            }
            NotificationRequest notiObj = new NotificationRequest
            {
                Title = "Hello! Time to analyze your work!",
                Description = "How was your day?",
                NotificationId = 100,

                // Repeats = isRepeat.IsChecked ? NotificationRepeat.TimeInterval : NotificationRepeat.No,
                // NotifyRepeatInterval = new TimeSpan(0, 0, 0, 10),
                // NotifyTime = DateTime.Now.AddSeconds(10)
                Android = 
                {
                    IconLargeName =
                            {
                                ResourceName = "meditate",
                            }
                },
                Schedule =
                {
                   // Used for Scheduling local notification
                   NotifyTime = DateTime.Today + _timePicker.Time, 
                   // Used if Repeat is checked 
                   RepeatType = isRepeatbutton.IsChecked ? NotificationRepeat.Daily : NotificationRepeat.No, 
                }

            };
            NotificationCenter.Current.Show(notiObj);
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            NotificationCenter.Current.CancelAll();
            await DisplayAlert("", "Notifications are cancelled", "Cancel");
        }
    }
}