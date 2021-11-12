using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                new Departamento
                {
                    DepartamentoId = new Guid("f029ae62-42e2-45b5-ae2f-db2c8cbd92cc"),
                    DepartamentoNome = "Nill"
                },
                new Departamento
                {
                    DepartamentoId = new Guid("a9f1e790-5a03-4d2f-8b4c-ac4049f29223"),
                    DepartamentoNome = "MyWay"
                },
                new Departamento
                {
                    DepartamentoId = new Guid("fc6c7a4e-0b99-4d31-b9f4-c465e785d3dc"),
                    DepartamentoNome = "Placa"
                },
                new Departamento
                {
                    DepartamentoId = new Guid("ee0bc74d-70f1-443a-a269-7c4c650578f4"),
                    DepartamentoNome = "Carga"
                },
                new Departamento
                {
                    DepartamentoId = new Guid("cebd6da4-8139-4f95-8b4b-2d8ede54acce"),
                    DepartamentoNome = "Passageiros"
                }
            );
        }
    }
}
