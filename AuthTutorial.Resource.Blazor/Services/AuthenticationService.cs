using AuthTutorial.Blazor.Model;
using AuthTutorial.Auth.Common;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthTutorial.Resource.Blazor.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        //private readonly HttpClient httpClient;

        public AuthenticationService()
        {
            //this.httpClient = httpClient;
        }

        public async Task<AuthLoginResult> Login(UserLogin login)
        {
            var httpClient = new HttpClient();
            string serializedUser = JsonConvert.SerializeObject(login);

            //TODO: web-address need moving to configuration file
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:51408/api/auth/login");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            HttpResponseMessage response;
            string responseBody = "";
            HttpStatusCode responseStatusCode = 0;
            string message;
            try
            {
                response = await httpClient.SendAsync(requestMessage);
                responseBody = await response.Content.ReadAsStringAsync();
                responseStatusCode = response.StatusCode;
                message = response.ReasonPhrase;
            }
            catch (Exception e)
            {
                message = e.Message;
            };

            var token = JsonConvert.DeserializeObject<ResponseJWT>(responseBody);
            
            var result = new AuthLoginResult() 
            { 
                Success = responseStatusCode == HttpStatusCode.OK, 
                Token = token.AccessToken,
                Message = message,
                ResultCode = (int)responseStatusCode
            };

            return await Task.FromResult(result);
        }
    }

    class ResponseJWT
    {
        public string AccessToken { get; set; }
    }
}
