using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notes : ContentPage
    {
        public Notes()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var temp = (Subjects)BindingContext;
            string mat = temp.Subject.ToString();

            listView.ItemsSource = await App.NoteDatabase.GetNoteBySubj(mat); //carica la lista degli appunti relativi alla materia scelta, inserita nella variabile mat
        }

        async void OnNoteAddedClicked(object sender, EventArgs e) //aggiungi un appunto
        {
            var temp = (Subjects)BindingContext;
            string mat = temp.Subject.ToString();
            await Navigation.PushAsync(new NotePage(mat));
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e) //visualizza un appunto
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NotePage { BindingContext = e.SelectedItem as Note });
            }
        }
    }
}