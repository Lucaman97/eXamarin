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
    public partial class AddSubj : ContentPage
    {
        public AddSubj()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var subj = (Subjects)BindingContext;
            await App.SubjectsDatabase.SaveSubjAsync(subj);
            await Navigation.PopAsync();
        }
    }
}