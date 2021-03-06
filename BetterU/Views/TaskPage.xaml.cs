
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

            listViewOverdue.ItemsSource = await App.Database.GetTasksOverdueAsync();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(Description.Text))
            {
                await App.Database.SaveTasksAsync(new Tasks
                {
                    Description = Description.Text,
                    Date = DateTime.Today,
                    Complete = false

                });
                Description.Text = string.Empty;
                listView.ItemsSource = await
                App.Database.GetTasksAsync();
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


        async void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            var checkbox = (CheckBox)sender;
            var ob = checkbox.BindingContext as Tasks;
            if (ob != null)

            {

                AddOrUpdatetheResult(ob, checkbox);

            }
        }
        async void AddOrUpdatetheResult(Tasks ob, CheckBox checkbox)
        {
            if (checkbox.IsChecked)
            {
                ob.Complete = true;
                await App.Database.SaveTasksAsync(ob);
            }
            else
            {
                ob.Complete = false;
                await App.Database.SaveTasksAsync(ob);
            }
        }
    }
}
