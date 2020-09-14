using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; 
using System.Linq;
using System.Threading.Tasks;

namespace AuthTutorial.Auth.Api.Models
{
    [Table("Person")]
    public class Person
    {
        [Column("PersonID")]
        [Key]
        public int Id { get; set; }

        [Column("PersonFirstName")]
        public string FirstName { get; set; }
        
        [Column("PersonLastName")]
        public string LastName { get; set; }
        
        [Column("PersonMiddleName")]
        public string MiddleName { get; set; }

       // public ICollection<Principal> Principals { get; set; } = new HashSet<Principal>();
    }
}
