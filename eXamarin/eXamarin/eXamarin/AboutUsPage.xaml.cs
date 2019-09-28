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
	public partial class AboutUsPage : ContentPage
	{
        Label txt;
        Label email1;
        Label email2;
        Label email3;
        Label contatti;
        StackLayout sl;
        public AboutUsPage ()
		{
			InitializeComponent ();
            this.Title = "About Us";

            txt = new Label
            {
                Text = "Siamo Simone, Luca e Danilo, studenti di Ingegneria Informatica dell'Università Politecnica delle Marche, abbiamo realizzato quest'applicazione come progetto per l'esame di Programmazione Mobile. Questa è la sua versione ibrida (Xamarin Forms), ne abbiamo realizzata anche una identica nativa in Android."
            };

            email1 = new Label
            {
                Text = "- simone.cappella1997@gmail.com"
            };

            email2 = new Label
            {
                Text = "- l.mannini97@gmail.com"
            };

            email3 = new Label
            {
                Text = "- danilo.tomassini.96@gmail.com"
            };

            contatti = new Label
            {
                Text = "Contatti:"
            };

            this.Padding = new Thickness(20);
            sl = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 10,
                Children =
                {
                    txt,
                    contatti,
                    email1,
                    email2,
                    email3
                }
            };

            this.Content = sl;
        }
	}
}