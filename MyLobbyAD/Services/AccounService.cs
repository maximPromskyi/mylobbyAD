using MyLobbyAD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLobbyAD.Services
{
    public class AccounService
    {
        public static string Token { get; private set; }

        public static string Email { get; private set; }
        public static string Created { get; private set; }
        public static string AccountId { get; private set; }
        public static int? Ttl { get; private set; }
        public static void CreateAccounService(LoginSuccess loginSuccess)
        {
            Token = loginSuccess?.Id;
            Created = loginSuccess?.Created;
            Email = loginSuccess?.Email;
            AccountId = loginSuccess?.UserId;
            Ttl = loginSuccess?.Ttl;
        }
    }
}
