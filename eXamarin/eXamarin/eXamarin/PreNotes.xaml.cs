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

        //bottone utilizzato per inserire le materie nel database
        async void OnAggMateriaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddSubj { BindingContext = new Subjects() }); //lancia la classe AddSubj per aggiungere una nuova materia alla lista
        }

        //metodo che permette di visualizzare la lista delle materie estratta dal database
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.SubjectsDatabase.GetSubjAsync();
        }

        //funzione che permette di captare quale elemento della lista è stato scelto e avvia la classe Notes, usando l'elemento scelto come argomento
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Notes { BindingContext = e.SelectedItem as Subjects });
            }
        }
    }
}