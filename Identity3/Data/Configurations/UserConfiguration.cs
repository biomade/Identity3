
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity3.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(
                new IdentityUser
                {
                    Id = "1",
                    UserName = "Admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abc123!"),
                    LockoutEnabled = true
                },
                new IdentityUser
                {
                    Id = "2",
                    UserName = "mary.lamb@gmail.com",
                    NormalizedUserName = "MARY.LAMB@GMAIL.COM",
                    Email = "mary.lamb@gmail.com",
                    NormalizedEmail = "MARY.LAMB@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abc123!"),
                    LockoutEnabled = true
                }
               ); 

        }
    }
}
