using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eXamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
        public MainMenu()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var topLeft = new Label { Text = "Top Left", BackgroundColor = Color.Red };
            var topRight = new Label { Text = "Top Right", BackgroundColor = Color.Blue };
            var bottomLeft = new Label { Text = "Bottom Left", BackgroundColor = Color.Green };
            var bottomRight = new Label { Text = "Bottom Right", BackgroundColor = Color.Yellow };
            // Image img1 = new Image();
            //Image img2 = new Image(); ...

            ImageButton img1 = new ImageButton
            {
                Source="calendar1.png",
                CornerRadius = 20,
                BackgroundColor = Color.White,
                Scale = 0.5,
            };
            ImageButton appunti = new ImageButton
            {
                Source = "book2.png",
                CornerRadius = 20,
                BackgroundColor = Color.White,
                Scale = 0.5,
            };
            ImageButton img3 = new ImageButton
            {
                Source = "www2.png",
                CornerRadius = 20,
                BackgroundColor = Color.White,
                Scale = 0.5,
            };
            ImageButton settings = new ImageButton
            {
                Source = "settings4.png",
                CornerRadius = 20,
                BackgroundColor = Color.White,
                Scale = 0.5,
            };

            grid.Children.Add(img1, 0, 0);
            grid.Children.Add(appunti, 1, 0);
            grid.Children.Add(img3, 0, 1);
            grid.Children.Add(settings, 1, 1);
            grid.ColumnSpacing = 20;
            grid.RowSpacing = 20;
            this.Padding = new Thickness(20, 160, 20, 20);
            Content = grid;

            appunti.Clicked += appunti_clicked;
            settings.Clicked += launchsettings;
            }

        void appunti_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PreNotes());
        }

        void launchsettings(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }
    }
    }