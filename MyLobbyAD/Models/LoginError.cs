using System;
using System.Collections.Generic;
using System.Text;

namespace MyLobbyAD.Models
{
    public class LoginError
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public int ErrorCode { get; set; }
    }
}
