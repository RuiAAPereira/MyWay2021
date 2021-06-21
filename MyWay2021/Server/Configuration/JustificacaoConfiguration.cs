using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class JustificacaoConfiguration : IEntityTypeConfiguration<Justificacao>
    {
        public void Configure(EntityTypeBuilder<Justificacao> builder)
        {
            builder.HasData(
               new Justificacao
               {
                   ID = new Guid("72c36203-f875-44e1-8536-c55b0c8980f5"),
                   Nome = "Atraso"
               },
               new Justificacao
               {
                   ID = new Guid("0267e756-9520-4c13-8ff9-33c2232605f9"),
                   Nome = "Acidente de trabalho"
               },
               new Justificacao
               {
                   ID = new Guid("77f61289-8ea8-4862-bc5d-b19093636140"),
                   Nome = "Incumprimento notificada"
               },
               new Justificacao
               {
                   ID = new Guid("b8884316-1b76-4fcc-a217-d4f855254837"),
                   Nome = "Incumprimento não notificada"
               }
           );
        }
    }
}
