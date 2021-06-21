using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class TipoMensagemConfiguration : IEntityTypeConfiguration<TipoMensagem>
    {
        public void Configure(EntityTypeBuilder<TipoMensagem> builder)
        {
            builder.HasData(
                new TipoMensagem
                {
                    ID = new Guid("2ec46bc8-ba5f-42a4-bddf-abe9f783d7a7"),
                    Tipo = "PAL"
                },
                new TipoMensagem
                {
                    ID = new Guid("4742160c-7d2c-4215-b53e-8c10f97863ab"),
                    Tipo = "CAL"
                },
                new TipoMensagem
                {
                    ID = new Guid("b5fe799e-3c53-4276-9d27-c5c9bfb95dbe"),
                    Tipo = "PSM"
                },
                new TipoMensagem
                {
                    ID = new Guid("c283da42-5812-4cf3-ba2c-0cddae1edfa8"),
                    Tipo = "NET"
                },
                new TipoMensagem
                {
                    ID = new Guid("2c8fb881-51fd-4a55-a86c-dbad23b30551"),
                    Tipo = "AD-HOC"
                }
            );
        }
    }
}
