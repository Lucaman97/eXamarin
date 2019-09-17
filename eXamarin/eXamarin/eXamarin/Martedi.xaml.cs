using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
	public partial class Martedi : ContentPage
	{
		public Martedi()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            LeggiDBOrario();


        }

        private void LeggiDBOrario()
        {
            var temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "8.30");
            if (temp.Result != null) { mat830.Text = temp.Result.materia; } else { mat830.Text = ""; }
            if (temp.Result != null) { aula830.Text = temp.Result.aula; } else { aula830.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "9.30");
            if (temp.Result != null) { mat930.Text = temp.Result.materia; } else { mat930.Text = ""; }
            if (temp.Result != null) { aula930.Text = temp.Result.aula; } else { aula930.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "10.30");
            if (temp.Result != null) { mat1030.Text = temp.Result.materia; } else { mat1030.Text = ""; }
            if (temp.Result != null) { aula1030.Text = temp.Result.aula; } else { aula1030.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "11.30");
            if (temp.Result != null) { mat1130.Text = temp.Result.materia; } else { mat1130.Text = ""; }
            if (temp.Result != null) { aula1130.Text = temp.Result.aula; } else { aula1130.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "12.30");
            if (temp.Result != null) { mat1230.Text = temp.Result.materia; } else { mat1230.Text = ""; }
            if (temp.Result != null) { aula1230.Text = temp.Result.aula; } else { aula1230.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "13.30");
            if (temp.Result != null) { mat1330.Text = temp.Result.materia; } else { mat1330.Text = ""; }
            if (temp.Result != null) { aula1330.Text = temp.Result.aula; } else { aula1330.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "14.30");
            if (temp.Result != null) { mat1430.Text = temp.Result.materia; } else { mat1430.Text = ""; }
            if (temp.Result != null) { aula1430.Text = temp.Result.aula; } else { aula1430.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "15.30");
            if (temp.Result != null) { mat1530.Text = temp.Result.materia; } else { mat1530.Text = ""; }
            if (temp.Result != null) { aula1530.Text = temp.Result.aula; } else { aula1530.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "16.30");
            if (temp.Result != null) { mat1630.Text = temp.Result.materia; } else { mat1630.Text = ""; }
            if (temp.Result != null) { aula1630.Text = temp.Result.aula; } else { aula1630.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "17.30");
            if (temp.Result != null) { mat1730.Text = temp.Result.materia; } else { mat1730.Text = ""; }
            if (temp.Result != null) { aula1730.Text = temp.Result.aula; } else { aula1730.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Martedì", "18.30");
            if (temp.Result != null) { mat1830.Text = temp.Result.materia; } else { mat1830.Text = ""; }
            if (temp.Result != null) { aula1830.Text = temp.Result.aula; } else { aula1830.Text = ""; }
        }

        private void Martedi830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "8.30"));

        }

        private void Martedi930(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "9.30"));
        }

        private void Martedi1030(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "10.30"));
        }

        private void Martedi1130(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "11.30"));
        }

        private void Martedi1230(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "12.30"));
        }

        private void Martedi1330(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "13.30"));
        }

        private void Martedi1430(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "14.30"));
        }
        private void Martedi1530(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "15.30"));
        }
        private void Martedi1630(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "16.30"));
        }
        private void Martedi1730(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "17.30"));
        }
        private void Martedi1830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Martedì", "18.30"));
        }






        private async void MartediX830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "8.30");
            LeggiDBOrario();

        }
        private async void MartediX930(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "9.30");
            LeggiDBOrario();

        }
        private async void MartediX1030(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "10.30");
            LeggiDBOrario();

        }
        private async void MartediX1130(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "11.30");
            LeggiDBOrario();

        }
        private async void MartediX1230(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "12.30");
            LeggiDBOrario();

        }
        private async void MartediX1330(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "13.30");
            LeggiDBOrario();

        }
        private async void MartediX1430(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "14.30");
            LeggiDBOrario();

        }
        private async void MartediX1530(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "15.30");
            LeggiDBOrario();

        }
        private async void MartediX1630(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "16.30");
            LeggiDBOrario();

        }
        private async void MartediX1730(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "17.30");
            LeggiDBOrario();

        }
        private async void MartediX1830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Martedì", "18.30");
            LeggiDBOrario();

        }
    }
}

