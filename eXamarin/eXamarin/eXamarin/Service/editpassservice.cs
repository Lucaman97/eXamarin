using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin.Service
{
    class editpassservice
    {
        private static HttpClient _client = new HttpClient();
        public static async Task changePass (string username, string oldpass, string newpass, string url)
        {
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("oldpass", oldpass),
                new KeyValuePair<string, string>("newpass", newpass)
        });

            var response = await _client.PostAsync(url, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Replace(" ", String.Empty);
            if (result.Equals("updated"))
            {
                Debug.WriteLine("modificata pass");
                DependencyService.Get<Message>().Shorttime("Password modificata con successo");
            }
            else if (result.Equals("passerrata"))
            {
                Debug.WriteLine("pass attuale errata");
                DependencyService.Get<Message>().Shorttime("Password attuale errata!");
            }else
            {
                Debug.WriteLine("Error");
                DependencyService.Get<Message>().Shorttime("Non è possibile lasciare campi vuoti");
            }
        }
    }
}
