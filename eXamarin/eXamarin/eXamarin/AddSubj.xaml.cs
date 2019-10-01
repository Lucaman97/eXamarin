using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSubj : ContentPage
    {
        public AddSubj()
        {
            InitializeComponent();
        }

        //funzione che parte una volta premuto sul bottone per salvare
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var subj = (Subjects)BindingContext;
            string materia = subj.Subject.ToString(); //la variabile materia viene riempita con la stringa della editText catturata
            Subjects control = new Subjects();
            control = await App.SubjectsDatabase.ControlSubjAsync(materia); //viene utilizzato control, oggetto Subject, per utilizzare il metodo in questione e controllare se la materia è gia presente ne database.
            if (control != null)
            {
                var message = "L'elemento esiste già, non è stato salvato...";//caso in cui la materia è già presente nel db
                DependencyService.Get<Message>().Longtime(message);
            }
            else
            {
                var message = "Salvato"; //la materia non è presente nel db
                DependencyService.Get<Message>().Longtime(message);
                await App.SubjectsDatabase.SaveSubjAsync(subj);
            }
            await Navigation.PopAsync(); //restituisce il controllo all'activity precedente
        }
    }
}