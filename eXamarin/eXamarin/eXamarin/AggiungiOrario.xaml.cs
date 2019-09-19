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
            var oreString = this.EdtOre.Text;
            int ore = Convert.ToInt32(oreString);
            System.Diagnostics.Debug.WriteLine(ore);
            //prima cancello eventuale altro orario
            if (ore == 1)
            {
                await App.OrarioDatabase.DeleteOrarioAsync(giornoAula, orarioAula);

                //poi salvo il nuovo
                Orario DBorario = new Orario();
                DBorario.giorno = giornoAula;
                DBorario.materia = materiaAula;
                DBorario.orario = orarioAula;
                DBorario.aula = this.EdtAula.Text;

                await App.OrarioDatabase.SaveOrarioAsync(DBorario);
            }
            else
            {
                while (ore != 0)
                {
                    await App.OrarioDatabase.DeleteOrarioAsync(giornoAula, orarioAula);
                    Debug.WriteLine(ore);
                    
                    //poi salvo il nuovo
                    Orario DBorario = new Orario();
                    DBorario.giorno = giornoAula;
                    DBorario.materia = materiaAula;
                    DBorario.orario = orarioAula;
                    DBorario.aula = this.EdtAula.Text;

                    await App.OrarioDatabase.SaveOrarioAsync(DBorario);
                    double orario = Convert.ToDouble(orarioAula);
                    Debug.WriteLine(orario);
                    orario++;
                    orarioAula = Convert.ToString(orario);
                    orarioAula = orarioAula + "0";
                    ore--;
                }
            }
            SalvaMateria(materiaAula);
            await Navigation.PopAsync();
        }

        async void SalvaMateria(string materia)
        {
            Subjects subj = new Subjects();
            subj.Subject = materia;
            Subjects control = new Subjects();
            control = await App.SubjectsDatabase.ControlSubjAsync(materia);
            if (control != null)
            {
                Debug.WriteLine("L'elemento esiste già, non verrà salvato");
            }
            else
            {
                Debug.WriteLine("L'elemento non esiste, verrà salvato");
                await App.SubjectsDatabase.SaveSubjAsync(subj);
            }
        }
        async void OnAnnullaClicked(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }

    }
}