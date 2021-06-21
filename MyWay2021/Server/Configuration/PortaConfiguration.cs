using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class PortaConfiguration : IEntityTypeConfiguration<Porta>
    {
        public void Configure(EntityTypeBuilder<Porta> builder)
        {
            builder.HasData(
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "07",
                PortaTempo = 12,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "08",
                PortaTempo = 12,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "8B",
                PortaTempo = 12,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "09",
                PortaTempo = 11,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "10",
                PortaTempo = 11,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "11",
                PortaTempo = 10,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "12",
                PortaTempo = 10,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "13",
                PortaTempo = 9,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "14",
                PortaTempo = 9,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "15",
                PortaTempo = 8,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "15A",
                PortaTempo = 8,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "16",
                PortaTempo = 8,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "16A",
                PortaTempo = 8,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "17",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "17A",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "18",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "18A",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "18B",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "19",
                PortaTempo = 8,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "20",
                PortaTempo = 8,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "21",
                PortaTempo = 6,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "22",
                PortaTempo = 5,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "22A",
                PortaTempo = 5,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "23",
                PortaTempo = 5,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "23A",
                PortaTempo = 5,
                Schengen = true,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "24",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "25",
                PortaTempo = 7,
                Schengen = true,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "26",
                PortaTempo = 12,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "27",
                PortaTempo = 12,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "41",
                PortaTempo = 13,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "41A",
                PortaTempo = 13,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "42",
                PortaTempo = 13,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "42A",
                PortaTempo = 13,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "43",
                PortaTempo = 14,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            },
            new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "43A",
                PortaTempo = 14,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "43B",
                PortaTempo = 14,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "44",
                PortaTempo = 15,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "44A",
                PortaTempo = 15,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "44B",
                PortaTempo = 15,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "45",
                PortaTempo = 16,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "45A",
                PortaTempo = 16,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "46",
                PortaTempo = 17,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "46A",
                PortaTempo = 17,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "47",
                PortaTempo = 16,
                Schengen = false,
                Terminal = true,
                Remoto = false,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "47A",
                PortaTempo = 16,
                Schengen = false,
                Terminal = true,
                Remoto = true,
                PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "201",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "202",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "203",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "204",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "205",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "206",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "207",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "208",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "209",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "209A",
                PortaTempo = 10,
                Schengen = true,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "210",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "211",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "211A",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "212",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "212A",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "214",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }, new Porta
            {
                PortaID = Guid.NewGuid(),
                PortaNum = "214A",
                PortaTempo = 10,
                Schengen = false,
                Terminal = false,
                Remoto = true,
                PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
            }
);
        }
    }
}
