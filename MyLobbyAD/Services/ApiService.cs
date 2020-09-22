using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MyLobbyAD.Services
{
    class ApiService
    {
        static readonly HttpClient client = new HttpClient();
        static private readonly string host = "https://eme.my-lobby.com";
        public static async Task<LoginInfoModel<LoginSuccess, LoginError>> Login(string email, string password)
        {
            var json = JsonConvert.SerializeObject(new { email, password });
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/users/login", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<LoginInfoModel<LoginSuccess, LoginError>>(result);
        }
    }
}
