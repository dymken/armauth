using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthTutorial.Auth.Api.Models
{
    [Table("Principal")]
    public class Principal
    {
        [Column("PrincipalID")]
        [Key]
        public int Id { get; set; }
        
        [Column("PrincipalName")]
        public string Name { get; set; }
        
        [Column("PrincipalPasswordHash")]
        public string PasswordHash { get; set; }

        [Column("PersonID")]
        public int? PersonID { get; set; }

        [ForeignKey("PersonID")]
        public Person Person { get; set; }

        public ICollection<PrincipalRole> PrincipalRoles { get; set; } = new HashSet<PrincipalRole>();
    }
}
