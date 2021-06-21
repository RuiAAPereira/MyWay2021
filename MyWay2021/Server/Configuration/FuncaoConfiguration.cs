using MyWay2021.Shared.Models.Tabelas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MyWay2021.Server.Configuration
{
    public class FuncaoConfiguration : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.HasData(
                new Funcao
                {
                    ID = new Guid("32d5f978-8841-4f41-9876-9d3bbc0d42ea"),
                    Nome = "Coordenador"
                },
                new Funcao
                {
                    ID = new Guid("d0704bcc-0316-438e-9c83-408bc3130754"),
                    Nome = "Sub. Coordenador"
                },
                new Funcao
                {
                    ID = new Guid("1cd22050-9302-46f8-bab3-a92963ea7086"),
                    Nome = "Administrativo"
                },
                new Funcao
                {
                    ID = new Guid("7978ce01-a193-47c8-993f-22ca803475da"),
                    Nome = "Supervisor"
                },
                new Funcao
                {
                    ID = new Guid("bae2d2f8-ca3a-4864-bce9-c50c784556dd"),
                    Nome = "Alocador"
                },
                new Funcao
                {
                    ID = new Guid("1400f058-b85c-47aa-96f8-bccab867d930"),
                    Nome = "Assistente"
                },
                new Funcao
                {
                    ID = new Guid("cf120207-b910-4c05-926d-1d7aea125b81"),
                    Nome = "Motorista"
                },
                new Funcao
                {
                    ID = new Guid("3bf6fda6-ff6c-4dfc-9b03-22fd59419ba6"),
                    Nome = "Motorista (ambulift)"
                }
            );
        }
    }
}
