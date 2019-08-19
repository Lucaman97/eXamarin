﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;

namespace eXamarin
{
    class MakeRequest
    {
        private static HttpClient _client = new HttpClient();
        public static async void setPost(String username, String pass, String URL)
        {
            HttpContent formcontent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("login_name", username),
                new KeyValuePair<string, string>("login_pass", pass)
            });

            var response = await _client.PostAsync(URL, formcontent);
            var result = response.Content.ReadAsStringAsync().Result.ToString();
            Debug.WriteLine(result);
            if (result.Equals("    Login Success  "))
            {
                Debug.WriteLine("Funge");
                LoginPage.flag = true; 
            }

            else
            {
                Debug.WriteLine("Error while inserting User in Post mode");
                LoginPage.flag = false;
            }

        }




    }
}
