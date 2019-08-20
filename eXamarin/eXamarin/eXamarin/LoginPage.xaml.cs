using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace eXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        public static Boolean flag = false;
        Button loginButton;
        Button registerButton;
        Entry passwordEntry;
        Entry usernameEntry;
        StackLayout stackLayout;
        Label text1;
        public LoginPage()
        {
            InitializeComponent();
            usernameEntry = new Entry
            {
                Placeholder = "Username",
                HorizontalTextAlignment = TextAlignment.Center
            };
            passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                HorizontalTextAlignment = TextAlignment.Center
            };
            loginButton = new Button
            {
                Text = "Login"
            };
            text1 = new Label
            {
                Text = "Oppure registrati!",
                HorizontalTextAlignment = TextAlignment.Center
            };
            registerButton = new Button
            {
                Text = "Crea un account"
            };

            loginButton.Clicked += LoginButton_Clicked;
            registerButton.Clicked += RegisterButton_Clicked;
            this.Padding = new Thickness(20);
            stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children = {
                        usernameEntry,
                        passwordEntry,
                        loginButton,
                        text1,
                        registerButton
                    }
            };

            this.Content = stackLayout;
        }

        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            string URL = "http://mobileproject.altervista.org/login.php";
            await MakeRequest.setPost(usernameEntry.Text, passwordEntry.Text, URL);
            //System.Threading.Thread.Sleep(15000);
            if (flag)
            {
                 Navigation.PushAsync(new RegistrationPage
                {
                });
            }
            else Debug.WriteLine("Dioporco");
        } 

        void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage
            {
            });
        }

    }
}
