using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin.Service
{
    class Registration
    {
        private static HttpClient _client = new HttpClient();
        public static async Task setPost(String username, String password, String URL)
        {
            //Creo form
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("user_name",username),
                new KeyValuePair<string, string>("user_pass",password)
            });
            //invio dati e prendo risposta
            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Trim();
            if (result.Equals("Registrazione avvenuta con successo!"))
            {
                DependencyService.Get<Message>().Longtime("Account creato con successo!");
                RegistrationPage.flag = true;
            } else if (result.Equals("Username in uso"))
            {
                DependencyService.Get<Message>().Longtime("Username già in uso.");
            } else
            {
                DependencyService.Get<Message>().Longtime("Si è verificato un errore, riprovare più tardi.");
            }
        }
    }
}
