using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
    public partial class Giovedi : ContentPage
    {
        public Giovedi()
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
            var temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "8.30");
            if (temp.Result != null) { mat830.Text = temp.Result.materia; } else { mat830.Text = ""; }
            if (temp.Result != null) { aula830.Text = temp.Result.aula; } else { aula830.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "9.30");
            if (temp.Result != null) { mat930.Text = temp.Result.materia; } else { mat930.Text = ""; }
            if (temp.Result != null) { aula930.Text = temp.Result.aula; } else { aula930.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "10.30");
            if (temp.Result != null) { mat1030.Text = temp.Result.materia; } else { mat1030.Text = ""; }
            if (temp.Result != null) { aula1030.Text = temp.Result.aula; } else { aula1030.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "11.30");
            if (temp.Result != null) { mat1130.Text = temp.Result.materia; } else { mat1130.Text = ""; }
            if (temp.Result != null) { aula1130.Text = temp.Result.aula; } else { aula1130.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "12.30");
            if (temp.Result != null) { mat1230.Text = temp.Result.materia; } else { mat1230.Text = ""; }
            if (temp.Result != null) { aula1230.Text = temp.Result.aula; } else { aula1230.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "13.30");
            if (temp.Result != null) { mat1330.Text = temp.Result.materia; } else { mat1330.Text = ""; }
            if (temp.Result != null) { aula1330.Text = temp.Result.aula; } else { aula1330.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "14.30");
            if (temp.Result != null) { mat1430.Text = temp.Result.materia; } else { mat1430.Text = ""; }
            if (temp.Result != null) { aula1430.Text = temp.Result.aula; } else { aula1430.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "15.30");
            if (temp.Result != null) { mat1530.Text = temp.Result.materia; } else { mat1530.Text = ""; }
            if (temp.Result != null) { aula1530.Text = temp.Result.aula; } else { aula1530.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "16.30");
            if (temp.Result != null) { mat1630.Text = temp.Result.materia; } else { mat1630.Text = ""; }
            if (temp.Result != null) { aula1630.Text = temp.Result.aula; } else { aula1630.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "17.30");
            if (temp.Result != null) { mat1730.Text = temp.Result.materia; } else { mat1730.Text = ""; }
            if (temp.Result != null) { aula1730.Text = temp.Result.aula; } else { aula1730.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Giovedì", "18.30");
            if (temp.Result != null) { mat1830.Text = temp.Result.materia; } else { mat1830.Text = ""; }
            if (temp.Result != null) { aula1830.Text = temp.Result.aula; } else { aula1830.Text = ""; }
        }

        private void Giovedi830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "8.30"));

        }

        private void Giovedi930(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "9.30"));
        }

        private void Giovedi1030(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "10.30"));
        }

        private void Giovedi1130(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "11.30"));
        }

        private void Giovedi1230(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "12.30"));
        }

        private void Giovedi1330(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "13.30"));
        }

        private void Giovedi1430(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "14.30"));
        }
        private void Giovedi1530(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "15.30"));
        }
        private void Giovedi1630(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "16.30"));
        }
        private void Giovedi1730(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "17.30"));
        }
        private void Giovedi1830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Giovedì", "18.30"));
        }






        private async void GiovediX830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "8.30");
            LeggiDBOrario();

        }
        private async void GiovediX930(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "9.30");
            LeggiDBOrario();

        }
        private async void GiovediX1030(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "10.30");
            LeggiDBOrario();

        }
        private async void GiovediX1130(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "11.30");
            LeggiDBOrario();

        }
        private async void GiovediX1230(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "12.30");
            LeggiDBOrario();

        }
        private async void GiovediX1330(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "13.30");
            LeggiDBOrario();

        }
        private async void GiovediX1430(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "14.30");
            LeggiDBOrario();

        }
        private async void GiovediX1530(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "15.30");
            LeggiDBOrario();

        }
        private async void GiovediX1630(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "16.30");
            LeggiDBOrario();

        }
        private async void GiovediX1730(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "17.30");
            LeggiDBOrario();

        }
        private async void GiovediX1830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Giovedì", "18.30");
            LeggiDBOrario();

        }
    }
}

