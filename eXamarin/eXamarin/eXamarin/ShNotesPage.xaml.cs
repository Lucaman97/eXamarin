using eXamarin.Models;
using eXamarin.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShNotesPage : ContentPage
    {
        ListView lv = new ListView();
        public ShNotesPage()
        {
            InitializeComponent();
        }

        public ShNotesPage(string materia)
        {
            this.Title = materia;
            loadShNotes(materia);
            lv.ItemSelected += (sender, e) =>
            {
                if (((ListView)sender).SelectedItem != null)
                {
                    Appunto selected = (Appunto)e.SelectedItem;
                    object txt = selected.Note;
                    object title = selected.Title;
                    ((ListView)sender).SelectedItem = null; selectednotehandler(sender, e, txt.ToString(), title.ToString());
                }
            };
            this.Content = lv;
        }

        async void loadShNotes(string materia)
        {
            string URL = "http://mobileproject.altervista.org/fetch_appunti.php";
            lv.ItemsSource = await SelectShNotes.setPost(URL, materia);
            lv.ItemTemplate = new DataTemplate(typeof(TextCell));
            lv.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            lv.ItemTemplate.SetBinding(TextCell.DetailProperty, "Date");
        }

        async void selectednotehandler(Object sender, EventArgs e, string txt, string title)
        {
            Debug.WriteLine("test->" + txt);
            await Navigation.PushAsync(new ViewNotePage(txt, title));
        }
    }
}