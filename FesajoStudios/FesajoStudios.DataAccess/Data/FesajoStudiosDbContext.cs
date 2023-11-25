using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.DataAccess.Data
{
    public class FesajoStudiosDbContext : IdentityDbContext<IdentityUserFesajoStudios>
    {
        public FesajoStudiosDbContext(DbContextOptions<FesajoStudiosDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // AspNetUsers
            modelBuilder.Entity<IdentityUserFesajoStudios>(e =>
            {
                e.ToTable("User");
            });

            // AspNetRoles
            modelBuilder.Entity<IdentityRole>(e =>
            {
                e.ToTable("Role");
            });

            // AspNetUserRoles
            modelBuilder.Entity<IdentityUserRole<string>>(e =>
            {
                e.ToTable("UserRole");
            });


        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Conventions.Remove(typeof(CascadeDeleteConvention));
        }

    }
}
