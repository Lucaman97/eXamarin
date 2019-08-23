using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
        public MainMenu()
        {
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
            Image imageButton1 = new Image
            {
                
                WidthRequest = 100,
                HeightRequest = 100,
                Source ="drawable\\book2.png"
            };

            Button button = new Button
            {
                ImageSource="book2.png"
            };
            grid.Children.Add(button, 0, 0);
            grid.Children.Add(topRight, 1, 0);
            grid.Children.Add(bottomLeft, 0, 1);
            grid.Children.Add(bottomRight, 1, 1);
            grid.ColumnSpacing = 20;
            grid.RowSpacing = 20;
            this.Padding = new Thickness(20, 160, 20, 20);
            Content = grid;
            }
        }
    }