using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWay2021.Shared.Models.Tabelas;
using System;

namespace MyWay2021.Server.Configuration
{
    public class StandConfiguration : IEntityTypeConfiguration<Stand>
    {
        public void Configure(EntityTypeBuilder<Stand> builder)
        {
            builder.HasData(
                new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 104,
                    Remoto = true,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 105,
                    Remoto = true,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 106,
                    Remoto = true,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 107,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 108,
                    Remoto = true,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("eea39faf-8802-4820-8c87-655d37f45741")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 114,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 115,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 116,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 117,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 122,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 123,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 124,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 125,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 126,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 141,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 142,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 143,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 144,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 145,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 146,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 147,
                    Remoto = false,
                    PlataformaId = new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"),
                    PierID = new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 200,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 201,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 202,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 203,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 204,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 205,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 206,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 207,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 208,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 209,
                    Remoto = true,
                    PlataformaId = new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"),
                    PierID = new Guid("3dd86690-5721-4331-8438-3aa673265b69")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 221,
                    Remoto = true,
                    PlataformaId = new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 222,
                    Remoto = true,
                    PlataformaId = new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 223,
                    Remoto = true,
                    PlataformaId = new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 224,
                    Remoto = true,
                    PlataformaId = new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 225,
                    Remoto = true,
                    PlataformaId = new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 301,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 302,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 401,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 402,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 403,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 404,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 405,
                    Remoto = true,
                    PlataformaId = new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 411,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 412,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 413,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 414,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 415,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 416,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 421,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 422,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 423,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 424,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 425,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 426,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 501,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 502,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 503,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 504,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 505,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 506,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 601,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 602,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 603,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"),
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 604,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 605,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 606,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 607,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 608,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 609,
                    Remoto = true,
                    PlataformaId = new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 701,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 702,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 703,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 704,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 705,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 706,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 801,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 802,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 803,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 804,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 805,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }, new Stand
                {
                    StandId = Guid.NewGuid(),
                    StandN = 806,
                    Remoto = true,
                    PlataformaId = new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"),
                    PierID = new Guid("bde32891-f337-44c8-b46b-9c911a42df3e")
                }
            );
        }
    }
}
