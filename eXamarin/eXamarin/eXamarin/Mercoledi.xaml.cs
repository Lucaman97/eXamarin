using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
    public partial class Mercoledi : ContentPage
    {
        public Mercoledi()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LeggiDBOrario();


        }

        private void LeggiDBOrario()
        {
            var temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "8.30");
            if (temp.Result != null) { mat830.Text = temp.Result.materia; } else { mat830.Text = ""; }
            if (temp.Result != null) { aula830.Text = temp.Result.aula; } else { aula830.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "9.30");
            if (temp.Result != null) { mat930.Text = temp.Result.materia; } else { mat930.Text = ""; }
            if (temp.Result != null) { aula930.Text = temp.Result.aula; } else { aula930.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "10.30");
            if (temp.Result != null) { mat1030.Text = temp.Result.materia; } else { mat1030.Text = ""; }
            if (temp.Result != null) { aula1030.Text = temp.Result.aula; } else { aula1030.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "11.30");
            if (temp.Result != null) { mat1130.Text = temp.Result.materia; } else { mat1130.Text = ""; }
            if (temp.Result != null) { aula1130.Text = temp.Result.aula; } else { aula1130.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "12.30");
            if (temp.Result != null) { mat1230.Text = temp.Result.materia; } else { mat1230.Text = ""; }
            if (temp.Result != null) { aula1230.Text = temp.Result.aula; } else { aula1230.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "13.30");
            if (temp.Result != null) { mat1330.Text = temp.Result.materia; } else { mat1330.Text = ""; }
            if (temp.Result != null) { aula1330.Text = temp.Result.aula; } else { aula1330.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "14.30");
            if (temp.Result != null) { mat1430.Text = temp.Result.materia; } else { mat1430.Text = ""; }
            if (temp.Result != null) { aula1430.Text = temp.Result.aula; } else { aula1430.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "15.30");
            if (temp.Result != null) { mat1530.Text = temp.Result.materia; } else { mat1530.Text = ""; }
            if (temp.Result != null) { aula1530.Text = temp.Result.aula; } else { aula1530.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "16.30");
            if (temp.Result != null) { mat1630.Text = temp.Result.materia; } else { mat1630.Text = ""; }
            if (temp.Result != null) { aula1630.Text = temp.Result.aula; } else { aula1630.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "17.30");
            if (temp.Result != null) { mat1730.Text = temp.Result.materia; } else { mat1730.Text = ""; }
            if (temp.Result != null) { aula1730.Text = temp.Result.aula; } else { aula1730.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Mercoledì", "18.30");
            if (temp.Result != null) { mat1830.Text = temp.Result.materia; } else { mat1830.Text = ""; }
            if (temp.Result != null) { aula1830.Text = temp.Result.aula; } else { aula1830.Text = ""; }
        }

        private void Mercoledi830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "8.30"));

        }

        private void Mercoledi930(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "9.30"));
        }

        private void Mercoledi1030(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "10.30"));
        }

        private void Mercoledi1130(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "11.30"));
        }

        private void Mercoledi1230(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "12.30"));
        }

        private void Mercoledi1330(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "13.30"));
        }

        private void Mercoledi1430(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "14.30"));
        }
        private void Mercoledi1530(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "15.30"));
        }
        private void Mercoledi1630(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "16.30"));
        }
        private void Mercoledi1730(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "17.30"));
        }
        private void Mercoledi1830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Mercoledì", "18.30"));
        }






        private async void MercolediX830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "8.30");
            LeggiDBOrario();

        }
        private async void MercolediX930(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "9.30");
            LeggiDBOrario();

        }
        private async void MercolediX1030(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "10.30");
            LeggiDBOrario();

        }
        private async void MercolediX1130(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "11.30");
            LeggiDBOrario();

        }
        private async void MercolediX1230(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "12.30");
            LeggiDBOrario();

        }
        private async void MercolediX1330(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "13.30");
            LeggiDBOrario();

        }
        private async void MercolediX1430(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "14.30");
            LeggiDBOrario();

        }
        private async void MercolediX1530(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "15.30");
            LeggiDBOrario();

        }
        private async void MercolediX1630(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "16.30");
            LeggiDBOrario();

        }
        private async void MercolediX1730(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "17.30");
            LeggiDBOrario();

        }
        private async void MercolediX1830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Mercoledì", "18.30");
            LeggiDBOrario();

        }
    }
}

