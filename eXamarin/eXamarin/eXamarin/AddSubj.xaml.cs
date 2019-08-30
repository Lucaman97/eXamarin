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

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var subj = (Subjects)BindingContext;
            string materia = subj.Subject.ToString();
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
            await Navigation.PopAsync();
        }
    }
}