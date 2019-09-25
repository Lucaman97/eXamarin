using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin.Service
{
    class editpassservice
    {
        private static HttpClient _client = new HttpClient();
        public static async Task changePass (string username, string oldpass, string newpass, string url)
        {
            //creo contenuto della form
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("oldpass", oldpass),
                new KeyValuePair<string, string>("newpass", newpass)
        });
            //invio richiesta e salvo il risultato
            var response = await _client.PostAsync(url, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Replace(" ", String.Empty);
            if (result.Equals("updated"))
            {
                DependencyService.Get<Message>().Shorttime("Password modificata con successo");
            }
            else if (result.Equals("passerrata"))
            {
                DependencyService.Get<Message>().Shorttime("Password attuale errata!");
            }else
            {
                DependencyService.Get<Message>().Shorttime("Non è possibile lasciare campi vuoti");
            }
        }
    }
}
