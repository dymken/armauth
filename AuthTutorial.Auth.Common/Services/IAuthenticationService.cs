using AuthTutorial.Auth.Common;
using AuthTutorial.Blazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTutorial.Auth.Common
{
    public interface IAuthenticationService
    {
        Task<AuthLoginResult> Login(UserLogin login);
    }
}
