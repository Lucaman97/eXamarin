using eXamarin.Models;
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
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            InitializeComponent();
            this.Title = "Impostazioni";
            ListView lv = new ListView();
            List<String> items = new List<String>() { "Modifica Username", "Modifica Password", "About Us" };
            lv.ItemsSource = new ListItem[]
            {
                new ListItem {Title = "Modifica Username", Description = "Cambia il nome del tuo account"},
                new ListItem {Title = "Modifica Password", Description = "Cambia la password del tuo account"},
                new ListItem {Title = "About Us", Description = "Informazioni sugli sviluppatori dell'app"},
            };
            lv.ItemTemplate = new DataTemplate(typeof(TextCell));
            //Binding con title
            lv.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            //Binding con descrizione
            lv.ItemTemplate.SetBinding(TextCell.DetailProperty, "Description");
            //lv.HasUnevenRows = true;
                lv.ItemSelected += (sender, e) =>
                {
                    if (((ListView)sender).SelectedItem != null)
                    {
                        ListItem nameli = (ListItem)e.SelectedItem;
                        object nome = nameli.Title;
                        ((ListView)sender).SelectedItem = null; listviewhandler(sender, e, nome.ToString());
                    }
                };
            
           
            this.Content = lv;
        }

        
             async void listviewhandler(object sender, EventArgs e, string nome)
        {
            switch(nome)
            {
                case "Modifica Username":
                    await Navigation.PushAsync(new EditUserPage());
                    break;
                case "Modifica Password":
                    await Navigation.PushAsync(new EditPassPage());
                    break;
                case "About Us":
                    await Navigation.PushAsync(new AboutUsPage());
                    break;
                default: DependencyService.Get<Message>().Longtime(nome);
                    break;
            }
        }
    }
}