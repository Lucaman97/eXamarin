using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaMaterie : ContentPage
    {
        public ListaMaterie(string giorno, string orario)
        {
            InitializeComponent();

            string[] LeMieMaterie = { "T.A.R", "Ricerca operativa", "Tecnologie web", "Programmazione ad oggetti", "Programmazione mobile", "Sistemi operativi", "Calcolatori e reti", "Materia nuova" };
            listamaterie.ItemsSource = LeMieMaterie;
            //menu.BackgroundColor = Color.Orange;


            listamaterie.ItemTapped += (sender, e) =>
            {

                Navigation.PopAsync();
                Navigation.PushAsync(new AggiungiOrario(e.Item.ToString(), giorno, orario));
            };


        }
    }
}