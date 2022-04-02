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
    public partial class RemoveTask : ContentPage
    {
        public RemoveTask()
        {
            InitializeComponent();
        }

        async void OnDeleteButtonAutoriClicked(object sender, EventArgs e)
        {
            var slist = (Tasks)BindingContext;
            await App.Database.DeleteTasksAsync(slist);
           // _ = DisplayAlert("Mesaj", "Stergere realizata cu succes", "OK");
            await Navigation.PopAsync();
        }
    }
}