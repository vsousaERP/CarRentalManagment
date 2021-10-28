using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagment.Server.Configurations.Entities
{
    public class UserRoleSeededConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "b358313a-661f-4f10-bf7d-46b6db6d2f95",
                    UserId = "fdb521f3-540e-4c7c-801e-09a989bd4bb1"
                },
                  new IdentityUserRole<string>
                  {
                      RoleId = "3b1478b3-e841-45b7-aae5-1e0c36dfb235",
                      UserId = "22780b4a-6510-411f-a27b-51ba342df45e"
                  }
                );
        }
    }
}
