using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Server.Models.Identity;

namespace MyWay2021.Server.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        private const string adminId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string utilizadorId = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3";
        private const string consultorId = "78A7570F-3CE5-48BA-9461-80283ED1D94D";

        public void Configure(EntityTypeBuilder<AppRole> builder)
        {

            builder.HasData(
                   new AppRole
                   {
                       Id = adminId,
                       Name = "Administrador",
                       NormalizedName = "ADMINISTRADOR"
                   },
                   new AppRole
                   {
                       Id = utilizadorId,
                       Name = "Utilizador",
                       NormalizedName = "UTILIZADOR"
                   },
                   new AppRole
                   {
                       Id = consultorId,
                       Name = "Consultor",
                       NormalizedName = "CONSULTOR"
                   }
               );
        }
    }
}
