using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWay2021.Server.Configuration
{
    public class PlataformaConfiguration : IEntityTypeConfiguration<Plataforma>
    {
        public void Configure(EntityTypeBuilder<Plataforma> builder)
        {
            builder.HasData(
                new Plataforma
                {
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PlataformaN = "Plataformas10a14"
                },
                new Plataforma
                {
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PlataformaN = "Plataformas20"
                },
                new Plataforma
                {
                    PlataformaId = new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"),
                    PlataformaN = "Plataformas22"
                },
                new Plataforma
                {
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PlataformaN = "Plataformas30a40"
                },
                new Plataforma
                {
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PlataformaN = "Plataformas41a60"
                },
                new Plataforma
                {
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PlataformaN = "Plataformas70a80"
                }
            );
        }
    }
}
