using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTutorial.Auth.Api.Models
{
    public class PrincipalRole
    {
        [Column("PrincipalRoleID")]
        [Key]
        public int Id { get; set; }
        
        [Column("PrincipalID")]
        public int PrincipalID { get; set; }
        public Principal Principal { get; set; }
        
        [Column("RoleID")]
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
