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
        StackLayout stackLayout;
        public LoginPage()
        {
            InitializeComponent();
            userNameEntry = new Entry
            {
                Placeholder = "username"
            };
            passwordEntry = new Entry
            {
                Placeholder = "password",
                IsPassword = true
            };
            loginButton = new Button
            {
                Text = "Login"
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
                        userNameEntry,
                        passwordEntry,
                        loginButton
                    }
            };

            this.Content = stackLayout;
        }
        void LoginButton_Clicked(object sender, EventArgs e)
        {
            string URL = "http://mobileproject.altervista.org/login.php";
            MakeRequest.setPost(userNameEntry.Text, passwordEntry.Text, URL);
        }
    }
}
