using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTutorial.Auth.Api.Models
{
    public class Role
    {
        [Column("RoleID")]
        [Key]
        public int Id { get; set; }

        [Column("RoleName")]
        public string Name { get; set; }
    }
}
