using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class PierConfiguration : IEntityTypeConfiguration<Pier>
    {
        public void Configure(EntityTypeBuilder<Pier> builder)
        {
            builder.HasData(
                new Pier
                {
                    PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741"),
                    PierNome = "Pier Sul"
                },
                new Pier
                {
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"),
                    PierNome = "Pier Norte"
                },
                new Pier
                {
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"),
                    PierNome = "Pier 14"
                },
                new Pier
                {
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69"),
                    PierNome = "Terminal 2"
                },
                new Pier
                {
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"),
                    PierNome = "Remoto"
                }
            );
        }
    }
}
