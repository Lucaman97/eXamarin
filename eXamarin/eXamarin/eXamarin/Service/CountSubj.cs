using eXamarin.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace eXamarin.Service
{
    class CountSubj
    {
        //Conta il numero di materie diverse presenti negli appunti condivisi
        private static HttpClient _client = new HttpClient();
        public static async Task<List<ListItemSubjects>> setGet(string URL)
        {
            var response = await _client.GetAsync(URL);
            var result = response.Content.ReadAsStringAsync().Result.ToString().Replace("   ",String.Empty);
            string[] words = result.Split('\r');
            List<ListItemSubjects> list = new List<ListItemSubjects>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                list.Add(new ListItemSubjects { Name = words[i] });
            }
            return list;
        }
    }
}
