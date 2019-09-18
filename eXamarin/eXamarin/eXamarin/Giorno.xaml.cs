using eXamarin.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
	public partial class Giorno : ContentPage
	{
        private string giorno;

        public Giorno(string giornoScelto)
		{
            InitializeComponent ();
            giorno = giornoScelto;
            titolo.Text = giornoScelto;

		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LeggiDBOrario();
                                  

        }

        private void LeggiDBOrario()
        {
            var temp = App.OrarioDatabase.ControlSubjAsync(giorno, "8.30");
            if (temp.Result != null) { mat830.Text = temp.Result.materia; } else { mat830.Text = ""; }
            if (temp.Result != null) { aula830.Text = temp.Result.aula; } else { aula830.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "9.30");
            if (temp.Result != null) { mat930.Text = temp.Result.materia; } else { mat930.Text = ""; }
            if (temp.Result != null) { aula930.Text = temp.Result.aula; } else { aula930.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "10.30");
            if (temp.Result != null) { mat1030.Text = temp.Result.materia; } else { mat1030.Text = ""; }
            if (temp.Result != null) { aula1030.Text = temp.Result.aula; } else { aula1030.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "11.30");
            if (temp.Result != null) { mat1130.Text = temp.Result.materia; } else { mat1130.Text = ""; }
            if (temp.Result != null) { aula1130.Text = temp.Result.aula; } else { aula1130.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "12.30");
            if (temp.Result != null) { mat1230.Text = temp.Result.materia; } else { mat1230.Text = ""; }
            if (temp.Result != null) { aula1230.Text = temp.Result.aula; } else { aula1230.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "13.30");
            if (temp.Result != null) { mat1330.Text = temp.Result.materia; } else { mat1330.Text = ""; }
            if (temp.Result != null) { aula1330.Text = temp.Result.aula; } else { aula1330.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "14.30");
            if (temp.Result != null) { mat1430.Text = temp.Result.materia; } else { mat1430.Text = ""; }
            if (temp.Result != null) { aula1430.Text = temp.Result.aula; } else { aula1430.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "15.30");
            if (temp.Result != null) { mat1530.Text = temp.Result.materia; } else { mat1530.Text = ""; }
            if (temp.Result != null) { aula1530.Text = temp.Result.aula; } else { aula1530.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "16.30");
            if (temp.Result != null) { mat1630.Text = temp.Result.materia; } else { mat1630.Text = ""; }
            if (temp.Result != null) { aula1630.Text = temp.Result.aula; } else { aula1630.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "17.30");
            if (temp.Result != null) { mat1730.Text = temp.Result.materia; } else { mat1730.Text = ""; }
            if (temp.Result != null) { aula1730.Text = temp.Result.aula; } else { aula1730.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync(giorno, "18.30");
            if (temp.Result != null) { mat1830.Text = temp.Result.materia; } else { mat1830.Text = ""; }
            if (temp.Result != null) { aula1830.Text = temp.Result.aula; } else { aula1830.Text = ""; }
        }

        private void Giorno830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno,"8.30"));

        }

        private void Giorno930(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "9.30"));
        }

        private void Giorno1030(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "10.30"));
        }

        private void Giorno1130(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "11.30"));
        }

        private void Giorno1230(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "12.30"));
        }

        private void Giorno1330(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "13.30"));
        }

        private void Giorno1430(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "14.30"));
        }
        private void Giorno1530(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "15.30"));
        }
        private void Giorno1630(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "16.30"));
        }
        private void Giorno1730(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "17.30"));
        }
        private void Giorno1830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie(giorno, "18.30"));
        }






        private async void GiornoX830(object sender, EventArgs e)
        {
                       
            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "8.30");
            LeggiDBOrario();

        }
        private async void GiornoX930(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "9.30");
            LeggiDBOrario();

        }
        private async void GiornoX1030(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "10.30");
            LeggiDBOrario();

        }
        private async void GiornoX1130(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "11.30");
            LeggiDBOrario();

        }
        private async void GiornoX1230(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "12.30");
            LeggiDBOrario();

        }
        private async void GiornoX1330(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "13.30");
            LeggiDBOrario();

        }
        private async void GiornoX1430(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "14.30");
            LeggiDBOrario();

        }
        private async void GiornoX1530(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "15.30");
            LeggiDBOrario();

        }
        private async void GiornoX1630(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "16.30");
            LeggiDBOrario();

        }
        private async void GiornoX1730(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "17.30");
            LeggiDBOrario();

        }
        private async void GiornoX1830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync(giorno, "18.30");
            LeggiDBOrario();

        }

    }
}

