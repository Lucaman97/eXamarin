﻿using System;
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
            ImageButton ShNotes = new ImageButton
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
            grid.Children.Add(ShNotes, 0, 1);
            grid.Children.Add(settings, 1, 1);
            grid.ColumnSpacing = 20;
            grid.RowSpacing = 20;
            this.Padding = new Thickness(20, 160, 20, 20);
            Content = grid;

            img1.Clicked += calendario_clicked;
            appunti.Clicked += appunti_clicked;
            settings.Clicked += launchsettings;
            ShNotes.Clicked += launchshnotes;
            }

        void calendario_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calendario());
        }

        void appunti_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PreNotes());
        }

        void launchsettings(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }

        void launchshnotes(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShNotes());
        }
    }
    }