using eXamarin.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
	public partial class Lunedi : ContentPage
	{
        
        public Lunedi()
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
            var temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "8.30");
            if (temp.Result != null) { mat830.Text = temp.Result.materia; } else { mat830.Text = ""; }
            if (temp.Result != null) { aula830.Text = temp.Result.aula; } else { aula830.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "9.30");
            if (temp.Result != null) { mat930.Text = temp.Result.materia; } else { mat930.Text = ""; }
            if (temp.Result != null) { aula930.Text = temp.Result.aula; } else { aula930.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "10.30");
            if (temp.Result != null) { mat1030.Text = temp.Result.materia; } else { mat1030.Text = ""; }
            if (temp.Result != null) { aula1030.Text = temp.Result.aula; } else { aula1030.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "11.30");
            if (temp.Result != null) { mat1130.Text = temp.Result.materia; } else { mat1130.Text = ""; }
            if (temp.Result != null) { aula1130.Text = temp.Result.aula; } else { aula1130.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "12.30");
            if (temp.Result != null) { mat1230.Text = temp.Result.materia; } else { mat1230.Text = ""; }
            if (temp.Result != null) { aula1230.Text = temp.Result.aula; } else { aula1230.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "13.30");
            if (temp.Result != null) { mat1330.Text = temp.Result.materia; } else { mat1330.Text = ""; }
            if (temp.Result != null) { aula1330.Text = temp.Result.aula; } else { aula1330.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "14.30");
            if (temp.Result != null) { mat1430.Text = temp.Result.materia; } else { mat1430.Text = ""; }
            if (temp.Result != null) { aula1430.Text = temp.Result.aula; } else { aula1430.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "15.30");
            if (temp.Result != null) { mat1530.Text = temp.Result.materia; } else { mat1530.Text = ""; }
            if (temp.Result != null) { aula1530.Text = temp.Result.aula; } else { aula1530.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "16.30");
            if (temp.Result != null) { mat1630.Text = temp.Result.materia; } else { mat1630.Text = ""; }
            if (temp.Result != null) { aula1630.Text = temp.Result.aula; } else { aula1630.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "17.30");
            if (temp.Result != null) { mat1730.Text = temp.Result.materia; } else { mat1730.Text = ""; }
            if (temp.Result != null) { aula1730.Text = temp.Result.aula; } else { aula1730.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Lunedì", "18.30");
            if (temp.Result != null) { mat1830.Text = temp.Result.materia; } else { mat1830.Text = ""; }
            if (temp.Result != null) { aula1830.Text = temp.Result.aula; } else { aula1830.Text = ""; }
        }

        private void Lunedi830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì","8.30"));

        }

        private void Lunedi930(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "9.30"));
        }

        private void Lunedi1030(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "10.30"));
        }

        private void Lunedi1130(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "11.30"));
        }

        private void Lunedi1230(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "12.30"));
        }

        private void Lunedi1330(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "13.30"));
        }

        private void Lunedi1430(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "14.30"));
        }
        private void Lunedi1530(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "15.30"));
        }
        private void Lunedi1630(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "16.30"));
        }
        private void Lunedi1730(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "17.30"));
        }
        private void Lunedi1830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Lunedì", "18.30"));
        }






        private async void LunediX830(object sender, EventArgs e)
        {
                       
            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "8.30");
            LeggiDBOrario();

        }
        private async void LunediX930(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "9.30");
            LeggiDBOrario();

        }
        private async void LunediX1030(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "10.30");
            LeggiDBOrario();

        }
        private async void LunediX1130(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "11.30");
            LeggiDBOrario();

        }
        private async void LunediX1230(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "12.30");
            LeggiDBOrario();

        }
        private async void LunediX1330(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "13.30");
            LeggiDBOrario();

        }
        private async void LunediX1430(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "14.30");
            LeggiDBOrario();

        }
        private async void LunediX1530(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "15.30");
            LeggiDBOrario();

        }
        private async void LunediX1630(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "16.30");
            LeggiDBOrario();

        }
        private async void LunediX1730(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "17.30");
            LeggiDBOrario();

        }
        private async void LunediX1830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Lunedì", "18.30");
            LeggiDBOrario();

        }

    }
}

