using System;
using System.IO;
using Xamarin.Forms;

namespace eXamarin
{
	public partial class TestIntent : ContentPage
	{
        Button merda;
        StackLayout sl;
		public TestIntent ()
		{
			InitializeComponent ();

            merda = new Button
            {
                Text = "Scoreggia"
            };

            this.Padding = new Thickness(20);
            sl = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children = {
                        merda
                    }
            };

            this.Content = sl;
        }
	}
}