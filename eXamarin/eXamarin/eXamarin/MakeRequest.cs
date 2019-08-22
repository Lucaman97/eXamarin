using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace eXamarin
{
    class MakeRequest
    {
        private static HttpClient _client = new HttpClient();
        public static async Task setPost(String username, String pass, String URL)
        {
            HttpContent formcontent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("login_name", username),
                new KeyValuePair<string, string>("login_pass", pass)
            });

            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString();
            Debug.WriteLine(result);
            if ( result.Equals("    Login Success  "))
            {
                Debug.WriteLine("Funge");
                LoginPage.loginflag = true; 
            }

            else
            {
                Debug.WriteLine("Error while inserting User in Post mode");
                LoginPage.loginflag = false;
            }

        }




    }
}
