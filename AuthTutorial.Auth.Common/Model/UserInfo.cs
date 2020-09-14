using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTutorial.Blazor.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; } = new List<string>();

        public override string ToString() => $"{FirstName} {LastName}";
        public void Clear()
        {
            Id = 0;
            Name = "";
            Token = "";
            FirstName = "";
            LastName = "";
            Email = "";
            Roles.Clear();
        }
    }
}
