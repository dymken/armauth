using AuthTutorial.Blazor.Model;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthTutorial.Auth.Common
{
    public class UserInfoJwt
    {
        public static string ToJwt(UserInfo userInfo, AuthOptions authOptions)
        {
            var securityKey = authOptions.GetSymmetricSecurityKey();
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim("email", userInfo.Email),
                new Claim("sub",   userInfo.Name),
                new Claim("jti",   userInfo.Id.ToString()),
                new Claim("fname", userInfo.FirstName),
                new Claim("lname", userInfo.LastName)
            };
            foreach (var role in userInfo.Roles)
                claims.Add(new Claim("role", role));

            var token = new JwtSecurityToken(
                issuer: authOptions.Issuer, 
                audience: authOptions.Audience, 
                claims: claims,
                expires: DateTime.Now.AddSeconds(authOptions.TokenLifeTime),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static UserInfo FromJwt(string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);
            var userInfo = new UserInfo();
            userInfo.Token = jwt;
            foreach (var claim in token.Claims)
            {
                if (claim.Type == "jti")
                    userInfo.Id = Int32.Parse(claim.Value);
                if (claim.Type == "sub")
                    userInfo.Name = claim.Value;
                if (claim.Type == "email")
                    userInfo.Email = claim.Value;
                if (claim.Type == "role")
                    userInfo.Roles.Add(claim.Value);
                if (claim.Type == "fname")
                    userInfo.FirstName = claim.Value;
                if (claim.Type == "lname")
                    userInfo.LastName = claim.Value;
            }
            return userInfo;
        }
    }
}
