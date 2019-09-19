using eXamarin.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eXamarin.Service
{
    class SelectShNotes
    {
        private static HttpClient _client = new HttpClient();
        public static async Task<List<Appunto>> setPost(string URL, string materia)
        {
            HttpContent formcontent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string,string>("materia_name", materia)
            });

            var response = await _client.PostAsync(URL, formcontent);
            string result = response.Content.ReadAsStringAsync().Result.ToString();
            var serverresp = (JObject) JsonConvert.DeserializeObject(result);
            int success = serverresp["success"].Value<int>();
            if (success == 1)
            {
                JArray valori = serverresp["data"].Value<JArray>();
                List<Appunto> list = new List<Appunto>();
                foreach (var appunto in valori)
                {
                    list.Add(new Appunto(appunto["materia_id"].Value<int>(),
                        materia,
                        appunto["appunto_titolo"].Value<string>(),
                        appunto["appunto_data"].Value<string>(),
                        appunto["appunto_link"].Value<string>()));
                }
                return list;
            }
            else
            {
                DependencyService.Get<Message>().Shorttime("Non sono presenti appunti per questa materia.");
                return null;
            }
        }
    }
}
