using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace eXamarin.Service
{
    class Login
    {
        private static HttpClient _client = new HttpClient();
        public static async Task setPost(String username, String pass, String URL)
        {
            //creo contenuto form
            HttpContent formcontent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("login_name", username),
                new KeyValuePair<string, string>("login_pass", pass)
            });
            //invio richiesta e salvo risposta
            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Trim();
            Debug.WriteLine(result);
            if ( result.Equals("Login Success"))
            {
                LoginPage.loginflag = true; 
            }

            else
            {
                LoginPage.loginflag = false;
            }

        }




    }
}
