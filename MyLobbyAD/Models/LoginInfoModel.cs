using System;
using System.Collections.Generic;
using System.Text;

namespace MyLobbyAD.Models
{
    public class LoginInfoModel<T, L>
    {
        public T Success { get; set; }
        public L Error { get; set; }
    }
}
