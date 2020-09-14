using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTutorial.Auth.Api.Models
{
    public class AuthDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<PrincipalRole> PrincipalRoles { get; set; }

        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Access");
            //modelBuilder.Entity<Principal>().HasMany(p => p.PrincipalRoles).WithOne(pr => pr.Principal);
        }
    }
}
