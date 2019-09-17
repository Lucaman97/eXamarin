using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eXamarin.Service
{
    class CountSubj
    {
        private static HttpClient _client = new HttpClient();
        public static async Task setGet(string URL)
        {
            var response = await _client.GetAsync(URL);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Replace("   ",String.Empty);
            string[] words = result.Split('\r');
            for (int i=0; i<words.Length -1 ; i++)
            {
                Debug.WriteLine(words[i]);
            }
        }
    }
}
