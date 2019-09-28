using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        private bool condividi;

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

            if(condividi==true)
            {
                await creaAppunto(note, "http://mobileproject.altervista.org");
                   
            }
        }

        private static async Task creaAppunto(Note note,  string URL)
        {
            string url1 = URL + "/create_appunto_Xamarin.php";
            //Faccio la richiesta POST per creare il file nel server
        HttpClient _client = new HttpClient();
        HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("appunto_contenuto", note.Notes),
                new KeyValuePair<string,string>("appunto_titolo", note.Title),
            });
            var response = await _client.PostAsync(url1, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Trim();
            if (result.Equals("Success"))
            {
                DependencyService.Get<Message>().Longtime("Appunto condiviso con successo!");
            }
            else
            {
                DependencyService.Get<Message>().Longtime("Si è verificato un errore, impossibile condividere l'appunto.");
            }


            //Altra richiesta POST per aggiungere il file al database per poterlo trovare e leggere in appunti condivisi
            string url2 = URL + "/add_appunti.php";
            HttpClient _client2 = new HttpClient();
            HttpContent formcontent2 = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("appunto_contenuto", note.Notes),
                new KeyValuePair<string,string>("appunto_link", "http://mobileproject.altervista.org/Appunti/" + note.Title + ".txt"),
                new KeyValuePair<string,string>("appunto_titolo", note.Title),
                new KeyValuePair<string,string>("appunto_data", note.Date),
                new KeyValuePair<string,string>("appunto_materia", note.Subject),
            });
            var response2 = await _client2.PostAsync(url2, formcontent2);
            var result2 = response2.Content.ReadAsStringAsync().Result.ToString().Trim();

        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.NoteDatabase.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
        async void OnCondividiChanged(object sender, CheckedChangedEventArgs e)
        {
           /* string URL = "http://mobileproject.altervista.org/add_appunti.php";

            HttpContent formcontent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("appunto_contenuto", Notes),
                new KeyValuePair<string, string>("appunto_titolo", titolo)
            });
            */
            // Perform required operation after examining e.Value
            if (e.Value)
            {
                condividi = true;
            }
            else
            {
                condividi = false;
            }

        }
    }
}