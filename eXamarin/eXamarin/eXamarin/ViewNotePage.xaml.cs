using System.Net;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewNotePage : ContentPage
    {
        Label txt;
        public ViewNotePage()
        {
            InitializeComponent();
        }

        public ViewNotePage(string link, string title)
        {
            this.Title = title;
            WebClient wc = new WebClient();
            //si connette al link e ne prende il file come uno stream di bit
            byte[] raw = wc.DownloadData(link);
            //traduce i byte in stringa
            string text = Encoding.UTF8.GetString(raw);
            txt = new Label
            {
                Text = text
            };
            this.Padding = new Thickness(10);
            this.Content = txt;
        }
    }
}