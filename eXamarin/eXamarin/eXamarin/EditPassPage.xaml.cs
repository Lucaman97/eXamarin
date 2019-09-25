using eXamarin.Service;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPassPage : ContentPage
    {
        StackLayout sl;
        Button changepsw;
        Entry oldpass;
        Entry newpass;

        public EditPassPage()
        {
            InitializeComponent();
            this.Title = "Modifica Password";

            oldpass = new Entry
            {
                Text = "",
                Placeholder = "Password attuale",
                HorizontalTextAlignment = TextAlignment.Center
            };

            newpass = new Entry
            {
                Text = "",
                Placeholder = "Nuova password",
                HorizontalTextAlignment = TextAlignment.Center
            };

            changepsw = new Button
            {
                Text = "Cambia!"
            };

            changepsw.Clicked += changepswfunction;
            this.Padding = new Thickness(20);

            sl = new StackLayout
            {

                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children =
                {
                    oldpass,
                    newpass,
                    changepsw
                }
            };

            this.Content = sl;

            async void changepswfunction(object sender, EventArgs e)
            {
                string URL = "http://mobileproject.altervista.org/editpass.php";
                if ((newpass.Text).Length >= 3)
                {
                    await editpassservice.changePass(LoginPage.loggedusr, oldpass.Text, newpass.Text, URL);
                }
                else
                {
                    DependencyService.Get<Message>().Shorttime("La lunghezza minima è di 3 caratteri!");
                }
            }
        }
    }
}