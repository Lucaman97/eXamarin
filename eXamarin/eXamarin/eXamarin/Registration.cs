using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eXamarin
{
    class Registration
    {
        private static HttpClient _client = new HttpClient();
        public static async Task setPost(String username, String password, String URL)
        {
            RegistrationPage.regflag = false;
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("user_name",username),
                new KeyValuePair<string, string>("user_pass",password)
            });

            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString();
            if (result.Equals("    Registrazione avvenuta con successo!  "))
            {
                Debug.WriteLine("Registrato");
                RegistrationPage.regflag = true;
            } else if (result.Equals("    Username in uso  "))
            {
                Debug.WriteLine("In uso");
            } else
            {
                Debug.WriteLine("Error");
            }
        }
    }
}
