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
				switch (e.Item.ToString())
				{
                    case "Lunedì":
                        gotoPage = new Lunedi();
                        break;
                    case "Martedì":
                        gotoPage = new Martedi();
                        break;
                    case "Mercoledì":
                        gotoPage = new Mercoledi();
                        break;
                    case "Giovedì":
                        gotoPage = new Giovedi();
                        break;
                    case "Venerdì":
                        gotoPage = new Venerdi();
                        break;
                    default:
                        gotoPage = new Lunedi();
                        break;
                }
				Detail = new NavigationPage(gotoPage);
				((ListView)sender).SelectedItem = null; 
				this.IsPresented = false;
			};

			Detail = new NavigationPage(new Lunedi());
		}
	}
}

