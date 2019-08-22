using System;
using System.Diagnostics;
using System.IO;
using Xamarin.Forms;

namespace eXamarin
{
    public partial class RegistrationPage : ContentPage
    {
        public static Boolean regflag = false;
        Entry usr;
        Entry psw;
        Button enterbtn;
        StackLayout sl;
        public RegistrationPage()
        {
            InitializeComponent();

            usr = new Entry
            {
                Placeholder = "Username",
                HorizontalTextAlignment = TextAlignment.Center
            };

            psw = new Entry
            {
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
                if(regflag)
                {
                    Debug.WriteLine("Marijuana");
                    var message1 = "Account creato!";
                    DependencyService.Get<Message>().Longtime(message1);
                    Navigation.PopAsync();
                }
                else
                {
                    Debug.WriteLine("Errore nella registrazione");
                    var message1 = "Account già esistente o campi vuoti!";
                    DependencyService.Get<Message>().Longtime(message1);
                }
            }

            this.Content = sl;
        }
    }
}