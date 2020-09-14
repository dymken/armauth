using AuthTutorial.Blazor.Model;
using AuthTutorial.Auth.Common;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AuthTutorial.Resource.Blazor.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private const string tokenKey = "accessToken";
        private readonly ILocalStorageService storage;
        private readonly IAuthenticationService authService;
        public UserInfo UserInfo { get; private set; }
        public CustomAuthenticationStateProvider(ILocalStorageService storageService, IAuthenticationService authService)
        {
            this.storage = storageService;
            this.authService = authService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync() 
        {
            var accessToken = await storage.GetItemAsync<string>(tokenKey);
            return string.IsNullOrWhiteSpace(accessToken) ? await CreateAnomymousState() : await CreateAuthenticatedState(accessToken);
        }

        public async Task<AuthLoginResult> Login(UserLogin userLogin)
        {
            var loginResult = await authService.Login(userLogin);
            if (loginResult.Success)
                await MarkUserAsLoggedIn(loginResult.Token);
            else
                await MarkUserAsLoggedOut();

            return await Task.FromResult(loginResult);
        }

        private async Task MarkUserAsLoggedIn(string accessToken)
        {
            await storage.SetItemAsync(tokenKey, accessToken);
            NotifyAuthenticationStateChanged( CreateAuthenticatedState(accessToken) );
        }

        public async Task MarkUserAsLoggedOut()
        {
            await storage.RemoveItemAsync(tokenKey);
            NotifyAuthenticationStateChanged( CreateAnomymousState() );
        }

        private async Task<AuthenticationState> CreateAuthenticatedState(string accessToken)
        {
            UserInfo = UserInfoJwt.FromJwt(accessToken);
            var authenticatedUser = CreateClaimsPrincipal(UserInfo);
            return await Task.FromResult(new AuthenticationState(authenticatedUser));
        }

        private async Task<AuthenticationState> CreateAnomymousState()
        {
            UserInfo = null;
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            return await Task.FromResult(new AuthenticationState(anonymousUser));
        }

        private ClaimsPrincipal CreateClaimsPrincipal(UserInfo userInfo)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("name", userInfo.Name));
            claims.Add(new Claim("email", userInfo.Email));
            foreach (var role in userInfo.Roles)
                claims.Add(new Claim("role", role));
            
            var identity = new ClaimsIdentity(claims, "jwt", "name", "role");
            return new ClaimsPrincipal(identity);
        }
    }
}
