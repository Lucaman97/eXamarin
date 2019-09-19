using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewNotePage : ContentPage
    {
        StackLayout sl;
        Label txt;
        public ViewNotePage()
        {
            InitializeComponent();
        }

        public ViewNotePage(string link, string title)
        {
            this.Title = title;
            WebClient wc = new WebClient();
            byte[] raw = wc.DownloadData(link);
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