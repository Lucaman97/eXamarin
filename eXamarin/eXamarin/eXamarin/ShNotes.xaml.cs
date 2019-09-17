using eXamarin.Service;
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
	public partial class ShNotes : ContentPage
	{
		public ShNotes ()
		{
			InitializeComponent ();
            this.Title = "Appunti condivisi";
            loadSubj();
		}

        async void loadSubj()
        {
        string URL = "http://mobileproject.altervista.org/getsubj.php";
        await CountSubj.setGet(URL);
        }
	}
}