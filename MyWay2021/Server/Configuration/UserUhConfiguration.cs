using MyWay2021.Server.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MyWay2021.Server.Configuration
{
    public class UserUhConfiguration : IEntityTypeConfiguration<UserUh>
    {
        private const string adminId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
        private const string lisId = "807aeb52-f2d7-4152-8410-a668604a41d4";
        private const string opoId = "7a525467-1367-4ddf-9802-6bc44ae695ac";
        private const string faoId = "7b277149-86d7-4c19-816c-0e97e803f491";
        private const string fncId = "7f6e20bd-7106-4c6f-a23d-dde9b0a1e471";

        public void Configure(EntityTypeBuilder<UserUh> builder)
        {
            builder.HasData(
                new UserUh
                {
                    UserId = new Guid(adminId),
                    UhID = new Guid(lisId)
                },
                new UserUh
                {
                    UserId = new Guid(adminId),
                    UhID = new Guid(opoId)
                },
                new UserUh
                {
                    UserId = new Guid(adminId),
                    UhID = new Guid(faoId)
                },
                new UserUh
                {
                    UserId = new Guid(adminId),
                    UhID = new Guid(fncId)
                }
            );
        }
    }
}
