using MyWay2021.Shared.Models.Tabelas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MyWay2021.Server.Configuration
{
    public class UhConfiguration : IEntityTypeConfiguration<Uh>
    {
        private const string lisId = "807aeb52-f2d7-4152-8410-a668604a41d4";
        private const string opoId = "7a525467-1367-4ddf-9802-6bc44ae695ac";
        private const string faoId = "7b277149-86d7-4c19-816c-0e97e803f491";
        private const string fncId = "7f6e20bd-7106-4c6f-a23d-dde9b0a1e471";

        public void Configure(EntityTypeBuilder<Uh> builder)
        {
            builder.HasData(
                new Uh
                {
                    ID = new Guid(lisId),
                    Nome = "Lisboa",
                    IATA = "LIS",
                    CodAeroporto= "AHD",
                    NomeAeroporto= "Aeroporto Humberto Delgado"
                },
                new Uh
                {
                    ID = new Guid(opoId),
                    Nome = "Porto",
                    IATA = "OPO",
                    CodAeroporto = "ASC",
                    NomeAeroporto = "Aeroporto Francisco Sá Carneiro"
                },
                new Uh
                {
                    ID = new Guid(faoId),
                    Nome = "Faro",
                    IATA = "FAO",
                    CodAeroporto = "AFR",
                    NomeAeroporto = "Aeroporto de Faro"
                },
                new Uh
                {
                    ID = new Guid(fncId),
                    Nome = "Funchal",
                    IATA = "FNC",
                    CodAeroporto = "ACR",
                    NomeAeroporto = "Aeroporto Cristiano Ronaldo"
                }
            );
        }
    }
}
