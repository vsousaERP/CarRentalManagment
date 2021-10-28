using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagment.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "3b1478b3-e841-45b7-aae5-1e0c36dfb235",
                    Name = "User",
                    NormalizedName = "USER"
                },
                 new IdentityRole
                 {
                     Id = "b358313a-661f-4f10-bf7d-46b6db6d2f95",
                     Name = "Administrator",
                     NormalizedName = "ADMINISTRATOR"
                 }
                );
        }
    }
}
