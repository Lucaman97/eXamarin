using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditUserPage : ContentPage
    {
        //public static Boolean useditFlag = false;
        StackLayout sl;
        Button changeusr;
        Entry oldusrn;
        Entry newusrn;

        public EditUserPage()
        {
            InitializeComponent();
            this.Title = "Modifica Username";
  
            newusrn = new Entry
            {
                Placeholder = "Nuovo username",
                HorizontalTextAlignment = TextAlignment.Center
            };

            changeusr = new Button
            {
                Text = "Cambia!"
            };

            changeusr.Clicked += changeusrfunction;
            this.Padding = new Thickness(20);

            sl = new StackLayout
            {
                
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children =
                {
                    newusrn,
                    changeusr
                }
            };

            this.Content = sl;

            async void changeusrfunction(object sender, EventArgs e)
            {
                string URL = "http://mobileproject.altervista.org/editusername.php";
                if ((newusrn.Text).Length >= 3)
                {
                    await edituserservice.changeUsr(LoginPage.loggedusr, newusrn.Text, URL);
                } else
                {
                    DependencyService.Get<Message>().Shorttime("La lunghezza minima è di 3 caratteri!");
                }
        }
        }
    }
}