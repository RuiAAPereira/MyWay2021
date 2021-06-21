using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class TipoAssistenciaConfiguration : IEntityTypeConfiguration<TipoAssistencia>
    {
        public void Configure(EntityTypeBuilder<TipoAssistencia> builder)
        {
            builder.HasData(
                new TipoAssistencia
                {
                    ID = new Guid("1b0cae90-9b19-49c4-9ddf-51d8d5577cc6"),
                    Tipo = "WCHR"
                },
                new TipoAssistencia
                {
                    ID = new Guid("7a86678b-64dd-4a5f-beac-13147a19de79"),
                    Tipo = "WCHS"
                },
                new TipoAssistencia
                {
                    ID = new Guid("d4d989d1-4b43-477c-8fa8-f09b891f8618"),
                    Tipo = "WCHC"
                },
                new TipoAssistencia
                {
                    ID = new Guid("57935f8b-8579-4a42-ae5e-2e62bbf169ca"),
                    Tipo = "BLIND"
                },
                new TipoAssistencia
                {
                    ID = new Guid("458fff44-5ec2-45b1-8b5d-2510b641cc91"),
                    Tipo = "DEAF"
                },
                new TipoAssistencia
                {
                    ID = new Guid("e01f774e-67e0-44a1-8671-8f90af915eb3"),
                    Tipo = "DPNA"
                },
                new TipoAssistencia
                {
                    ID = new Guid("348ed92b-fc54-44cd-a760-817a41e22e1c"),
                    Tipo = "MAAS"
                }
            );
        }
    }
}
