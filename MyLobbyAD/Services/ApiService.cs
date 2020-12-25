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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using MaterialSkin.Controls;

namespace MyLobbyAD.Services
{
    class ApiService
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string host = "https://admin.my-lobby.com";

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
        public static async Task<string> EmployeeAdd(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/employees/add?access_token={StorageService.InfoData.Token}", data);
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Employee>(result)?.EmployeeId;
        }
        public static async Task<bool> UploadImage(Object image, string employeeId)
        {

            var byteArrayContent = new ByteArrayContent((byte[])image);
            MultipartFormDataContent multipart = new MultipartFormDataContent();
            string imageName = Guid.NewGuid().ToString();
            multipart.Add(byteArrayContent, "file", imageName);
            var response = await client.PostAsync($"{host}/api/employees/uploadAvatar/{employeeId}?access_token=" +
                $"{StorageService.InfoData.Token}", multipart);
            string result = response.Content.ReadAsStringAsync().Result;
            return result != null;
        }
        public static async Task<bool> EmployeeUpdate(User user)
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
        public static async Task<Success> UploadUsers(MaterialProgressBar progressBar = null)
        {
            List<User> users = ActiveDirectory.GetUsers();
            string[] usersId = users.Select(u => u.Id.ToString()).ToArray();
            LoginInfoModel<EmployeeInfo[], LoginError> employeesInfo = await CheckEmployeeById(usersId);

            Success success = new Success();

            if (employeesInfo.Error != null)
            {
                return success;
            }

            int index = 1;
            foreach (User user in users)
            {
                EmployeeInfo employeeInfo = employeesInfo.Success
                    .Where(e => e.ActiveDirectoryId == user.Id.ToString())
                    .FirstOrDefault();
                if (StorageService.InfoData.InfoSyncs[user.Id])
                {
                    if (employeeInfo.EmployeeId != null)
                    {
                        user.EmployeeId = employeeInfo.EmployeeId;
                        await EmployeeUpdate(user);
                        success.CountUpdateEmployees++;
                    }
                    else
                    {
                        user.EmployeeId = await EmployeeAdd(user);
                        success.CountAddEmployees++;
                    }

                    if (user.Image != null)
                    {
                        await UploadImage(user.Image, user.EmployeeId);
                    }
                }

                if (progressBar != null)
                {
                    progressBar.Value = Convert.ToInt32(Convert.ToDouble(index / users.Count) * 100);
                }

                index++;
            }
            success.IsSuccess = true;
            return success;
        }
    }
}
