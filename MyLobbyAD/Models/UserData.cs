using System;
using System.Collections.Generic;
using System.Text;

namespace MyLobbyAD.Models
{
    [Serializable]
    class UserData
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string AccountId { get; set; }
        public DateTime NextUpdate { get; set; }
    }
}
