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
    public partial class NotePage : ContentPage
    {
        private string mat;
        public NotePage()
        {
            InitializeComponent();
        }

        public NotePage(string materia)
        {
            InitializeComponent();
            mat = materia;
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            Note note = new Note();
            string title = this.EdtTitle.Text;
            string date = this.EdtDate.Text;
            string notes = this.EdtNotes.Text;
            note.Subject = mat;
            note.Title = title;
            note.Date = date;
            note.Notes = notes;

            await App.NoteDatabase.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.NoteDatabase.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}