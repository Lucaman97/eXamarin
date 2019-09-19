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
    public partial class ShNotes : ContentPage
    {
        ListView lv = new ListView();
        public ShNotes()
        {
            InitializeComponent();
            this.Title = "Appunti condivisi";
            loadSubj();
            lv.ItemSelected += (sender, e) =>
            {
                if (((ListView)sender).SelectedItem != null)
                {
                    ListItemSubjects selected = (ListItemSubjects)e.SelectedItem;
                    object nome = selected.Name;
                    ((ListView)sender).SelectedItem = null; listviewhandler(sender, e, nome.ToString());
                }
            };
            this.Content = lv;

        }

        async void loadSubj()
        {
            string URL = "http://mobileproject.altervista.org/getsubj.php";
            lv.ItemsSource = await CountSubj.setGet(URL);
            lv.ItemTemplate = new DataTemplate(typeof(TextCell));
            lv.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
        }

        async void listviewhandler(object sender, EventArgs e, string nome)
        {
            await Navigation.PushAsync(new ShNotesPage(nome));
        }
    }
}