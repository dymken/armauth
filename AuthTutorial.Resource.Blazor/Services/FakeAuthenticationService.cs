using AuthTutorial.Auth.Common;
using AuthTutorial.Blazor.Model;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace AuthTutorial.Resource.Blazor.Services
{
    public class FakeAuthenticationService: IAuthenticationService
    {
        private readonly IConfiguration configuration;
        public FakeAuthenticationService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<AuthLoginResult> Login(UserLogin login)
        {
            var accessToken = "";
            var message = "";
            var userInfo = AuthenticateUser(login);
            if (userInfo != null)
            {
                accessToken = GenerateJwt(userInfo);
            }
            else
            {
                message = "Invalid Username or Password";
            };

            var result = new AuthLoginResult() { Success = accessToken != "", Token = accessToken, Message = message };
            return await Task.FromResult(result);
        }

        private UserInfo AuthenticateUser(UserLogin userLogin)
        {
            UserInfo userInfo = null;
            if (userLogin.UserName == "PlyasunovDS" && userLogin.Password == "123")
            {
                userInfo = new UserInfo
                {
                    Id = 1,
                    Name = "PlyasunovDS",
                    Email = "plyasunov@mail.ru",
                    FirstName = "Dmitry",
                    LastName = "Plyasunov",
                    Roles = { "admin" }
                };
            } else if (userLogin.UserName == "IvanovII" && userLogin.Password == "123") 
            {
                userInfo = new UserInfo
                {
                    Id = 2,
                    Name = "IvanovII",
                    Email = "ivanov@mail.ru",
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Roles = { "user" }
                };
            }
            return userInfo;
        }

        private string GenerateJwt(UserInfo userInfo)
        {
            var authOptions = configuration.GetSection("AuthOptions").Get<AuthOptions>();
            return UserInfoJwt.ToJwt(userInfo, authOptions);
        }

    }
}
