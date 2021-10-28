using CarRentalManagment.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagment.Server.Configurations.Entities
{
    public class UserSeededConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "fdb521f3-540e-4c7c-801e-09a989bd4bb1",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                },
                  new ApplicationUser
                  {
                      Id = "22780b4a-6510-411f-a27b-51ba342df45e",
                      Email = "user@localhost.com",
                      NormalizedEmail = "USER@LOCALHOST.COM",
                      FirstName = "System",
                      LastName = "User",
                      UserName = "user@localhost.com",
                      NormalizedUserName = "USER@LOCALHOST.COM",
                      PasswordHash = hasher.HashPassword(null, "P@ssword1")
                  }
                ) ;
        }
    }
}
