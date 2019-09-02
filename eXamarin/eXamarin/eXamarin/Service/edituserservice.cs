using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin.Service
{
    class edituserservice
    {
        private static HttpClient _client = new HttpClient();
        public static async Task changeUsr(string oldusername, string newusername, string URL)
        {
            //EditUserPage.useditFlag = false;
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("oldusername",oldusername),
                new KeyValuePair<string, string>("newusername",newusername)
            });

            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Replace(" ", String.Empty);
            if (result.Equals("modificato"))
            {
                Debug.WriteLine("Modificato");
                DependencyService.Get<Message>().Shorttime("Username modificato!");
                LoginPage.loggedusr = newusername;
                //EditUserPage.useditFlag = true;
            }
            else if (result.Equals("inuso"))
            {
                Debug.WriteLine("In uso");
                DependencyService.Get<Message>().Shorttime("Username già in uso!");
            }
            else
            {
                DependencyService.Get<Message>().Shorttime("Campo vuoto!");
                Debug.WriteLine(result);
            }
        }
    }
}
