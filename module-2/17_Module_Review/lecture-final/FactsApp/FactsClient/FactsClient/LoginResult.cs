using System;
using System.Collections.Generic;
using System.Text;

namespace FactsClient
{
    public class LoginResult
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
