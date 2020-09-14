using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthTutorial.Blazor.Model;
using AuthTutorial.Auth.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthTutorial.Resource.Blazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService authService;

        public LoginController(IAuthenticationService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody]UserLogin login)
        {
            var principal = authService.Login(login);
            var user = principal.Result;
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
