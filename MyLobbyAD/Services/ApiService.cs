using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace MyLobbyAD.Services
{
    class ApiService
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string host = "https://eme.my-lobby.com";
        public static async Task<LoginInfoModel<LoginSuccess, LoginError>> Login(string email, string password)
        {
            var json = JsonConvert.SerializeObject(new { email, password });
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/users/login", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<LoginInfoModel<LoginSuccess, LoginError>>(result);
        }
        public static async Task<bool> EmployeeAdd(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/add?access_token={AccounService.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return result != null;
        }
        public static async Task<bool> EmployeUpdate(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/edit?access_token={AccounService.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return result != null;
        }
        public static async Task<LoginInfoModel<EmployeeInfo[], LoginError>> CheckEmployeeById(string[] usersId)
        {
            var json = JsonConvert.SerializeObject(new {
                accountId = AccounService.AccountId,
                activeDirectoryUsersId = usersId
            });
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/checkByAdId?access_token={AccounService.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<LoginInfoModel<EmployeeInfo[], LoginError>>(result);

        }
    }
}
