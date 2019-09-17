using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
    public partial class Venerdi : ContentPage
    {
        public Venerdi()
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
            var temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "8.30");
            if (temp.Result != null) { mat830.Text = temp.Result.materia; } else { mat830.Text = ""; }
            if (temp.Result != null) { aula830.Text = temp.Result.aula; } else { aula830.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "9.30");
            if (temp.Result != null) { mat930.Text = temp.Result.materia; } else { mat930.Text = ""; }
            if (temp.Result != null) { aula930.Text = temp.Result.aula; } else { aula930.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "10.30");
            if (temp.Result != null) { mat1030.Text = temp.Result.materia; } else { mat1030.Text = ""; }
            if (temp.Result != null) { aula1030.Text = temp.Result.aula; } else { aula1030.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "11.30");
            if (temp.Result != null) { mat1130.Text = temp.Result.materia; } else { mat1130.Text = ""; }
            if (temp.Result != null) { aula1130.Text = temp.Result.aula; } else { aula1130.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "12.30");
            if (temp.Result != null) { mat1230.Text = temp.Result.materia; } else { mat1230.Text = ""; }
            if (temp.Result != null) { aula1230.Text = temp.Result.aula; } else { aula1230.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "13.30");
            if (temp.Result != null) { mat1330.Text = temp.Result.materia; } else { mat1330.Text = ""; }
            if (temp.Result != null) { aula1330.Text = temp.Result.aula; } else { aula1330.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "14.30");
            if (temp.Result != null) { mat1430.Text = temp.Result.materia; } else { mat1430.Text = ""; }
            if (temp.Result != null) { aula1430.Text = temp.Result.aula; } else { aula1430.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "15.30");
            if (temp.Result != null) { mat1530.Text = temp.Result.materia; } else { mat1530.Text = ""; }
            if (temp.Result != null) { aula1530.Text = temp.Result.aula; } else { aula1530.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "16.30");
            if (temp.Result != null) { mat1630.Text = temp.Result.materia; } else { mat1630.Text = ""; }
            if (temp.Result != null) { aula1630.Text = temp.Result.aula; } else { aula1630.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "17.30");
            if (temp.Result != null) { mat1730.Text = temp.Result.materia; } else { mat1730.Text = ""; }
            if (temp.Result != null) { aula1730.Text = temp.Result.aula; } else { aula1730.Text = ""; }

            temp = App.OrarioDatabase.ControlSubjAsync("Venerdì", "18.30");
            if (temp.Result != null) { mat1830.Text = temp.Result.materia; } else { mat1830.Text = ""; }
            if (temp.Result != null) { aula1830.Text = temp.Result.aula; } else { aula1830.Text = ""; }
        }

        private void Venerdi830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "8.30"));

        }

        private void Venerdi930(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "9.30"));
        }

        private void Venerdi1030(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "10.30"));
        }

        private void Venerdi1130(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "11.30"));
        }

        private void Venerdi1230(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "12.30"));
        }

        private void Venerdi1330(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "13.30"));
        }

        private void Venerdi1430(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "14.30"));
        }
        private void Venerdi1530(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "15.30"));
        }
        private void Venerdi1630(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "16.30"));
        }
        private void Venerdi1730(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "17.30"));
        }
        private void Venerdi1830(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMaterie("Venerdì", "18.30"));
        }






        private async void VenerdiX830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "8.30");
            LeggiDBOrario();

        }
        private async void VenerdiX930(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "9.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1030(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "10.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1130(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "11.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1230(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "12.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1330(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "13.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1430(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "14.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1530(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "15.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1630(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "16.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1730(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "17.30");
            LeggiDBOrario();

        }
        private async void VenerdiX1830(object sender, EventArgs e)
        {

            await App.OrarioDatabase.DeleteOrarioAsync("Venerdì", "18.30");
            LeggiDBOrario();

        }
    }
}

