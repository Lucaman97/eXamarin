using System;
using eXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreNotes : ContentPage
    {
        public PreNotes()
        {
            InitializeComponent();
        }

        //bottone provvisorio utilizzato per inserire le materie nel database
        async void OnAggMateriaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSubj { BindingContext = new Subjects() });
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.SubjectsDatabase.GetSubjAsync();
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Notes { BindingContext = e.SelectedItem as Subjects });
            }
        }
    }
}