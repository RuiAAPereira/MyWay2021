using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Server.Models.Identity;
using System;

namespace MyWay2021.Server.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        private const string adminId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser
            {
                Id = adminId,
                UserName = "rapereira",
                NormalizedUserName = "RAPEREIRA",
                Nome = "Rui Pereira",
                Email = "rui.santos@portway.pt",
                NormalizedEmail = "RUI.SANTOS@PORTWAY.PT",
                PhoneNumber = "XXXXXXXXXXXXX",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = new Guid().ToString("D")
            };

            admin.PasswordHash = PassGenerate(admin);

            builder.HasData(admin);
        }

        public string PassGenerate(AppUser user)
        {
            var passHash = new PasswordHasher<AppUser>();
            return passHash.HashPassword(user, "rui0504");
        }
    }
}
