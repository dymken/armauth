using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthTutorial.Auth.Api.Models;
using Microsoft.Extensions.Options;
using AuthTutorial.Auth.Common;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AuthTutorial.Blazor.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthTutorial.Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IOptions<AuthOptions> AuthOptions { get; }
        public AuthDbContext Context { get; }
        public AuthController(IOptions<AuthOptions> authOptions, AuthDbContext context)
        {
            AuthOptions = authOptions;
            Context = context;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody]UserLogin userLogin)
        {
            var userInfo = AuthenticateUser(userLogin.UserName, userLogin.Password);
            if (userInfo != null)
            {
                var token = UserInfoJwt.ToJwt(userInfo, AuthOptions.Value);
                return Ok(new { AccessToken = token });
            }

            return Unauthorized();
        }

        private UserInfo AuthenticateUser(string name, string password)
        {
            var principal = Context.Principals.Include(p => p.Person).SingleOrDefault(p => p.Name == name && p.PasswordHash == password);
            UserInfo userInfo = null;

            if (principal != null)
            {
                userInfo = new UserInfo()
                {
                    Id        = principal.Id,
                    FirstName = principal.Person?.FirstName ?? "",
                    LastName  = principal.Person?.LastName ?? "",
                    Name      = principal.Name,
                    Email     = "example@aa.com"
                };
            }

            return userInfo;
        }
    }
}
