using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {

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
        void LoginButton_Clicked(object sender, EventArgs e)
        {
            string URL = "http://mobileproject.altervista.org/login.php";
            MakeRequest.setPost(usernameEntry.Text, passwordEntry.Text, URL);
        }
    }
}
