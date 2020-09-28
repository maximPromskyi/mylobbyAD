using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Linq;
using System.Net;

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
        public static async Task<bool> GetUser()
        {
            string token = StorageService.InfoData.Token;
            string userId = StorageService.InfoData.AccountId;
            var response = await client.GetAsync($"{host}/api/users/{userId}?access_token={token}");
            return response.StatusCode == HttpStatusCode.OK;
        }
        public static async Task<bool> EmployeeAdd(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/add?access_token={StorageService.InfoData.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return result != null;
        }
        public static async Task<bool> EmployeUpdate(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/edit?access_token={StorageService.InfoData.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return result != null;
        }
        public static async Task<LoginInfoModel<EmployeeInfo[], LoginError>> CheckEmployeeById(string[] usersId)
        {
            var json = JsonConvert.SerializeObject(new {
                accountId = StorageService.InfoData.AccountId,
                activeDirectoryUsersId = usersId
            });
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/checkByAdId?access_token={StorageService.InfoData.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<LoginInfoModel<EmployeeInfo[], LoginError>>(result);

        }
        public static async Task<bool> UploadUsers()
        {
            List<User> users = ActiveDirectory.GetUsers();
            string[] usersId = users.Select(u => u.Id.ToString()).ToArray();
            LoginInfoModel<EmployeeInfo[], LoginError> employeesInfo = await CheckEmployeeById(usersId);
            string usersData = "";
            string usersUpdateData = "";
            string usersError = "";
            foreach (User user in users)
            {
                EmployeeInfo employeeInfo = employeesInfo.Success
                    .Where(e => e.ActiveDirectoryId == user.Id.ToString())
                    .FirstOrDefault();
                if (employeeInfo.EmployeeId != null)
                {
                    user.EmployeeId = employeeInfo.EmployeeId;
                    if (await ApiService.EmployeUpdate(user))
                    {
                        usersUpdateData += $"{user.Name}\n";
                    }
                    else
                    {
                        usersError += $"{user.Name}\n";
                    }
                }
                else
                {
                    if (await ApiService.EmployeeAdd(user))
                    {
                        usersData += $"{user.Name}\n";
                    }
                    else
                    {
                        usersError += $"{user.Name}\n";
                    }
                }

            }
            return true;
        }
    }
}
