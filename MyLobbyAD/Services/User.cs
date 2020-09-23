using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLobbyAD.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "activeDirectoryId")]
        public Guid Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        [JsonProperty(PropertyName = "jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "phonesms")]
        public string PhoneSms { get; set; }

        [JsonProperty(PropertyName = "phonevoice")]
        public string PhoneVoice { get; set; }

        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string EmployeeId { get; set; }

    }
}
