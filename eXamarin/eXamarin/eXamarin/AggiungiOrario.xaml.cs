using eXamarin.Models;
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
    public partial class AggiungiOrario : ContentPage
    {
        private string materiaAula;
        private string giornoAula;
        private string orarioAula;

        public AggiungiOrario(string materiascelta, string giornoscelto, string orarioscelto)
        {
            InitializeComponent();

            materiaAula = materiascelta;
            giornoAula = giornoscelto;
            orarioAula = orarioscelto;
           
            MateriaScelta.Text = materiaAula;
            OrarioScelto.Text = orarioAula;

        }

        async void OnSalvaClicked(object sender, EventArgs args)
        {
            //prima cancello eventuale altro orario
            await App.OrarioDatabase.DeleteOrarioAsync(giornoAula, orarioAula);
            
            //poi salvo il nuovo
            Orario DBorario = new Orario();
            DBorario.giorno = giornoAula;
            DBorario.materia = materiaAula;
            DBorario.orario = orarioAula;
            DBorario.aula = this.EdtAula.Text;

            await App.OrarioDatabase.SaveOrarioAsync(DBorario);
            await Navigation.PopAsync();
     

        }
        async void OnAnnullaClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }

    }
}