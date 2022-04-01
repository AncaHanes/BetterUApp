
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BetterU.Tables;
using BetterU.Data;
using System.Windows.Input;



namespace BetterU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : ContentPage
    {
        public TaskPage()
        {

            InitializeComponent();


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetTasksAsync();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(Description.Text))
            {
                await App.Database.SaveTasksAsync(new Tasks
                {
                    Description = Description.Text,
                    Date = DateTime.Today,
                    Complete = true

                });
                Description.Text = string.Empty;
                listView.ItemsSource = await
                App.Database.GetTasksAsync();
            }
        }



        async void ImageButton_Clicked(object sender, EventArgs e)
        {

            // var task = await App.Database.GetTasksAsync(Convert.ToInt32(Description.Text));

            var obj = (Tasks)BindingContext;
            // await App.Database.DeleteTasksAsync(task);


            // var item = await App.Database.GetTasksAsync(Convert.ToInt32(Description.Text));
            if (obj != null)
            {
                await App.Database.DeleteTasksAsync(obj);
            }

        }
        async void ItemSelected_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new RemoveTask
                {
                    BindingContext = e.SelectedItem as Tasks
                });
            }
        }



        private void CheckBox_CheckChanged(object sender, CheckedChangedEventArgs e)
        {

            //  bool checkbox = e.Value;

        }

    }
}
