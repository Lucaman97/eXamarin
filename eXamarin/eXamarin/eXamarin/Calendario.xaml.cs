using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace eXamarin
{
	public partial class Calendario : MasterDetailPage
	{
		public Calendario ()
		{
			InitializeComponent ();

			string[] myPageNames = { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì" };
			menu.ItemsSource = myPageNames;
            //menu.BackgroundColor = Color.Orange;


            menu.ItemTapped += (sender, e) =>
			{
				ContentPage gotoPage;
                gotoPage = new Giorno(e.Item.ToString());
                Detail = new NavigationPage(gotoPage);
				((ListView)sender).SelectedItem = null; 
				this.IsPresented = false;
			};

			Detail = new NavigationPage(new Giorno("Lunedì"));
		}
	}
}

