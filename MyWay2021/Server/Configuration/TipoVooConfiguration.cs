using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class TipoVooConfiguration : IEntityTypeConfiguration<TipoVoo>
    {
        public void Configure(EntityTypeBuilder<TipoVoo> builder)
        {
            builder.HasData(
                new TipoVoo
                {
                    ID = new Guid("aaca62fc-8ad2-4a0a-a2ee-c1d94cd86700"),
                    Tipo = "ARR"
                },
                new TipoVoo
                {
                    ID = new Guid("cd5d4ce2-f51e-4c93-a1ab-6b3e73688305"),
                    Tipo = "DEP"
                }
            );
        }
    }
}
