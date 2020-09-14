using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTutorial.Auth.Common
{
    public class AuthResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int ResultCode { get; set; }
    }

    public class AuthLoginResult : AuthResult
    {
        public string Token { get; set; }
    }
}
