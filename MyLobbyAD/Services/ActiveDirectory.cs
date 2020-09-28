using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLobbyAD.Services
{
    public class ActiveDirectory
    {
        private static PrincipalSearcher searcher;
        public static bool IsConnect 
        {
            get
            {
                return searcher != null;
            }
        }
        public static async Task<bool> Connect()
        {
            searcher = await Task.Run(() => 
            {
                try 
                {
                    return new PrincipalSearcher(
                        new UserPrincipal(
                            new PrincipalContext(ContextType.Domain, Environment.UserDomainName)));
                } 
                catch 
                {
                    return null;
                }

            });
            return IsConnect;
        }

        public static async Task<bool> Connect(string domainName, string username, string password)
        {
            searcher = await Task.Run(() =>
            {
                try
                {
                    return new PrincipalSearcher(
                    new UserPrincipal(
                        new PrincipalContext(ContextType.Domain, domainName, username, password)));
                }
                catch
                {
                    return null;
                }
            });
            return IsConnect;
        }
        public static List<User> GetUsers()
        {
            if (!IsConnect)
            {
                return null;
            }
            List<User> users = new List<User>();
            List<UserPrincipal> usersData = searcher
                .FindAll()
                .Select(user => (UserPrincipal)user)
                .ToList();

            foreach (var user in usersData)
            {
                DirectoryEntry dirEntry = (DirectoryEntry)user.GetUnderlyingObject();
                string firstName = dirEntry?.Properties["GivenName"]?.Value?.ToString();

                if (NameExist(firstName))
                {
                    users.Add(CreateUser(dirEntry));
                }
            }

            return users;
        }
        private static bool NameExist(string name)
        {
            return name != null;
        }
        private static string GetFullName(string firstName, string lastName)
        {
            return lastName == null ? firstName : $"{firstName} {lastName}";
        }
        private static User CreateUser(DirectoryEntry dirEntry)
        {
            return new User()
            {
                Id = dirEntry.Guid,
                Name = GetFullName(dirEntry?.Properties["GivenName"]?.Value?.ToString(), dirEntry.Properties["sn"]?.Value?.ToString()),
                Company = dirEntry.Properties["company"]?.Value?.ToString() == null ? "" : dirEntry.Properties["company"]?.Value?.ToString(),
                JobTitle = dirEntry.Properties["title"]?.Value?.ToString() == null ? "" : dirEntry.Properties["title"]?.Value?.ToString(),
                Email = dirEntry.Properties["mail"]?.Value?.ToString() == null ? "" : dirEntry.Properties["mail"]?.Value?.ToString(),
                PhoneSms = dirEntry.Properties["telephoneNumber"]?.Value?.ToString() == null ? "" : dirEntry.Properties["telephoneNumber"]?.Value?.ToString(),
                PhoneVoice = dirEntry.Properties["telephoneNumber"]?.Value?.ToString() == null ? "" : dirEntry.Properties["telephoneNumber"]?.Value?.ToString(),
                AccountId = StorageService.InfoData.AccountId
            };
        }
        public static string GetDomain()
        {
            if (IsConnect && searcher?.Context?.Name != null)
            {
                return searcher.Context.Name;
            }
            return "unknown";
        }
    }
}
