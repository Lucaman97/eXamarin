using eXamarin.Service;
using System;
using System.Diagnostics;
using System.IO;
using Xamarin.Forms;

namespace eXamarin
{
    public partial class RegistrationPage : ContentPage
    {
        Entry usr;
        Entry psw;
        Button enterbtn;
        StackLayout sl;
        public RegistrationPage()
        {
            InitializeComponent();

            usr = new Entry
            {
                Text = "",
                Placeholder = "Username",
                HorizontalTextAlignment = TextAlignment.Center
            };

            psw = new Entry
            {
                Text = "",
                Placeholder = "Password",
                HorizontalTextAlignment = TextAlignment.Center,
                IsPassword = true
            };

            enterbtn = new Button
            {
                Text = "Registrati"
            };

            enterbtn.Clicked += Register_req;

            this.Padding = new Thickness(20);
            sl = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children = {
                        usr,
                        psw,
                        enterbtn
                    }
            };

            async void Register_req(object sender, EventArgs e)
            {
                string URL = "http://mobileproject.altervista.org/register.php";
                await Registration.setPost(usr.Text, psw.Text, URL);
                if((usr.Text).Length >= 3 && (psw.Text).Length >=3)
                {
                    var message1 = "Account creato!";
                    DependencyService.Get<Message>().Longtime(message1);
                    await Navigation.PopAsync();
                }
                else
                {
                    Debug.WriteLine("Errore nella registrazione");
                    var message1 = "La lunghezza minima è di 3 caratteri!";
                    DependencyService.Get<Message>().Longtime(message1);
                }
            }

            this.Content = sl;
        }
    }
}