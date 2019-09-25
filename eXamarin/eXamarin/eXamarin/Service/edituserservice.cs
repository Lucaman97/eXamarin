using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin.Service
{
    class edituserservice
    {
        private static HttpClient _client = new HttpClient();
        public static async Task changeUsr(string oldusername, string newusername, string URL)
        {
            //creo contenuto della form
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("oldusername",oldusername),
                new KeyValuePair<string, string>("newusername",newusername)
            });
            //invio richiesta e salvo risposta
            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Replace(" ", String.Empty);
            if (result.Equals("modificato"))
            {
                DependencyService.Get<Message>().Shorttime("Username modificato!");
                LoginPage.loggedusr = newusername;
            }
            else if (result.Equals("inuso"))
            {
                DependencyService.Get<Message>().Shorttime("Username già in uso!");
            }
            else
            {
                DependencyService.Get<Message>().Shorttime("Campo vuoto!");
            }
        }
    }
}
