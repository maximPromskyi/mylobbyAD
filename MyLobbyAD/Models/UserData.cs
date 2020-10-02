using System;
using System.Collections.Generic;
using System.Configuration;
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
        public DateTime PreviousUpdate { get; set; }
        public string Key { get; set; }
        public Dictionary<Guid, bool> InfoSyncs { get; set; }
    }
}
