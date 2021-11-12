using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class ParametroConfiguration : IEntityTypeConfiguration<Parametro>
    {
        public void Configure(EntityTypeBuilder<Parametro> builder)
        {
            builder.HasData(
                new Parametro
                {
                    ParamID = new Guid("87bfaa02-ea40-43f5-827f-ecc16a224e59"),
                    ParamNome = "CPS",
                    ParamDesc = "Chegada PAX Schengen ao aeroporto",
                    ParamValue = 120
                },
                new Parametro
                {
                    ParamID = new Guid("dd3ca9e4-a051-4d75-9bec-f9aa57635d31"),
                    ParamNome = "CPN",
                    ParamDesc = "Chegada PAX Não Schengen ao aeroporto",
                    ParamValue = 180
                },
                new Parametro
                {
                    ParamID = new Guid("00eb563f-79c1-4fe8-9690-f655afbfe6c2"),
                    ParamNome = "NAmbulift",
                    ParamDesc = "Quantidade de ambulift's necessários vs num PAP",
                    ParamValue = 4
                },
                new Parametro
                {
                    ParamID = new Guid("b8f99886-3412-475a-b2a0-2670a436688e"),
                    ParamNome = "NVta",
                    ParamDesc = "Quantidade de VTA's necessárias vs pmr no voo",
                    ParamValue = 5
                }
            );
        }
    }
}
