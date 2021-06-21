using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWay2021.Server.Migrations
{
    public partial class Tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "HorasExtra");

            migrationBuilder.DropTable(
                name: "Incumprimentos");

            migrationBuilder.DropTable(
                name: "Slas");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "RelatoriosDiarios");

            migrationBuilder.CreateTable(
                name: "AssistenciasPRMS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aeroporto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Msg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Voo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrigDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CkIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transferencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraEmbarque = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaidaStaging = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimaApresentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistenciasPRMS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DadosAeroportos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Voo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduleTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlockTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BeginBRD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndBRD = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduleTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BlockTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BeginBRDUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndBRDUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosAeroportos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Escalas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Equipa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escalas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoAssistencias",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Msg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aeroporto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataContacto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Voo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrigDest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CkIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transferencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoAssistencias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    ParamID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParamNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParamDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParamValue = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.ParamID);
                });

            migrationBuilder.CreateTable(
                name: "Piers",
                columns: table => new
                {
                    PierID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PierNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piers", x => x.PierID);
                });

            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    PlataformaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlataformaN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.PlataformaId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SalaNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    UhID = table.Column<int>(type: "int", nullable: false),
                    UhID1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaID);
                    table.ForeignKey(
                        name: "FK_Salas_Uhs_UhID1",
                        column: x => x.UhID1,
                        principalTable: "Uhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Portas",
                columns: table => new
                {
                    PortaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PortaNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortaTempo = table.Column<int>(type: "int", nullable: false),
                    Schengen = table.Column<bool>(type: "bit", nullable: false),
                    Terminal = table.Column<bool>(type: "bit", nullable: false),
                    Remoto = table.Column<bool>(type: "bit", nullable: false),
                    PierID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portas", x => x.PortaID);
                    table.ForeignKey(
                        name: "FK_Portas_Piers_PierID",
                        column: x => x.PierID,
                        principalTable: "Piers",
                        principalColumn: "PierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stands",
                columns: table => new
                {
                    StandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StandN = table.Column<int>(type: "int", nullable: false),
                    Remoto = table.Column<bool>(type: "bit", nullable: false),
                    PlataformaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PierID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stands", x => x.StandId);
                    table.ForeignKey(
                        name: "FK_Stands_Piers_PierID",
                        column: x => x.PierID,
                        principalTable: "Piers",
                        principalColumn: "PierID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stands_Plataformas_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataformas",
                        principalColumn: "PlataformaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parametros",
                columns: new[] { "ParamID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "ParamDesc", "ParamNome", "ParamValue" },
                values: new object[,]
                {
                    { new Guid("87bfaa02-ea40-43f5-827f-ecc16a224e59"), null, null, null, null, "Chegada PAX Schengen ao aeroporto", "CPS", 120 },
                    { new Guid("dd3ca9e4-a051-4d75-9bec-f9aa57635d31"), null, null, null, null, "Chegada PAX Não Schengen ao aeroporto", "CPN", 180 },
                    { new Guid("00eb563f-79c1-4fe8-9690-f655afbfe6c2"), null, null, null, null, "Quantidade de ambulift's necessários vs num PAP", "NAmbulift", 4 },
                    { new Guid("b8f99886-3412-475a-b2a0-2670a436688e"), null, null, null, null, "Quantidade de VTA's necessárias vs pmr no voo", "NVta", 5 }
                });

            migrationBuilder.InsertData(
                table: "Piers",
                columns: new[] { "PierID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierNome" },
                values: new object[,]
                {
                    { new Guid("eea39faf-8802-4820-8c87-655d37f45741"), null, null, null, null, "Pier Sul" },
                    { new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), null, null, null, null, "Pier Norte" },
                    { new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), null, null, null, null, "Pier 14" },
                    { new Guid("3dd86690-5721-4331-8438-3aa673265b69"), null, null, null, null, "Terminal 2" },
                    { new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), null, null, null, null, "Remoto" }
                });

            migrationBuilder.InsertData(
                table: "Plataformas",
                columns: new[] { "PlataformaId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PlataformaN" },
                values: new object[,]
                {
                    { new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), null, null, null, null, "Plataformas70a80" },
                    { new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), null, null, null, null, "Plataformas41a60" },
                    { new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), null, null, null, null, "Plataformas30a40" },
                    { new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), null, null, null, null, "Plataformas10a14" },
                    { new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), null, null, null, null, "Plataformas20" },
                    { new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), null, null, null, null, "Plataformas22" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "8104a148-44e5-42d7-a5a6-e137d1de6532");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "121c0209-8615-4b11-948e-bece98187a53");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "a0a4ed52-b598-4240-9ef1-e841821e71f5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44377ac0-c720-4f51-8bf7-dde0e33eb482", "AQAAAAEAACcQAAAAEC3YoMcjeEH+KWE12vFh4zNeTaPseK/aqR6B/Y3KNJpmYWanrzw8Fbqr0EUp4kGf9Q==" });

            migrationBuilder.InsertData(
                table: "Portas",
                columns: new[] { "PortaID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PortaNum", "PortaTempo", "Remoto", "Schengen", "Terminal" },
                values: new object[,]
                {
                    { new Guid("ba1dbf02-f8f0-4c3a-b50b-ae61a18854a1"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "07", 12, false, true, true },
                    { new Guid("8f27a1b3-4bd1-477c-bf9a-8a83ef680c90"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43", 14, false, false, true },
                    { new Guid("eeede2e7-b80a-4c07-b3e0-a89c96075604"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43A", 14, true, false, true },
                    { new Guid("527c93a7-24fe-4519-bd1c-3c1555882ad0"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "43B", 14, true, false, true },
                    { new Guid("b8bd0c40-8d19-4264-8307-ff97573e99a5"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44", 15, false, false, true },
                    { new Guid("8ff3c410-46a6-442f-8d6c-f33bcdb1fb8e"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44A", 15, true, false, true },
                    { new Guid("9d788f3d-f838-46f8-ac07-1f32c4f1515e"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "44B", 15, true, false, true },
                    { new Guid("6fd19c5c-b537-4e19-af87-d737c184564c"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "45", 16, false, false, true },
                    { new Guid("c79140ea-1170-4853-a959-345cc9384a09"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "45A", 16, true, false, true },
                    { new Guid("a4726fc4-2869-4808-a4ed-97ba682365e5"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "46", 17, false, false, true },
                    { new Guid("71cb1c6e-00b7-4620-bef8-d4c2e8871277"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "46A", 17, true, false, true },
                    { new Guid("29003281-16dd-466c-8caf-95f6f65c9e65"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "47", 16, false, false, true },
                    { new Guid("f81f6996-1451-4680-93b8-76ef67fa4211"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "47A", 16, true, false, true },
                    { new Guid("cdf85394-646f-4a61-a26d-be1c6992c5d5"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "201", 10, true, true, false },
                    { new Guid("26e1d836-aa02-4b65-957b-522f267e8f15"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "42A", 13, true, false, true },
                    { new Guid("0d60fee7-148a-44b6-81ae-9d44ec731b68"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "202", 10, true, true, false },
                    { new Guid("981d2e96-d6ad-4575-805e-3a3b053d29b4"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "204", 10, true, true, false },
                    { new Guid("72abc606-9343-4c13-b939-3006681e4740"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "205", 10, true, true, false },
                    { new Guid("f420430d-72f3-4417-829f-7290ef3b7133"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "207", 10, true, true, false },
                    { new Guid("9901a9f3-08bb-4a9c-b552-52a6df2c5421"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "208", 10, true, true, false },
                    { new Guid("aae76272-4b71-4716-86e7-89ab54b9121e"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "209", 10, true, true, false },
                    { new Guid("bea4f581-9ef7-45f6-9185-a53dd0aa8bab"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "209A", 10, true, true, false },
                    { new Guid("0b38a4bd-5545-42bd-94f1-e23313425c21"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "210", 10, true, false, false },
                    { new Guid("0edd2fc2-85b7-48c3-bf70-c2b228241974"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "211", 10, true, false, false },
                    { new Guid("94206d7b-b3ec-4ad8-9871-4736e98a9724"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "211A", 10, true, false, false },
                    { new Guid("b2b2487b-4209-4f16-9c09-7c12e8a72f19"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "212", 10, true, false, false },
                    { new Guid("509007ec-95e9-4103-8183-62ed5188d007"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "212A", 10, true, false, false },
                    { new Guid("186f25c2-46f0-4e64-9b8e-8683013e93aa"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "214", 10, true, false, false },
                    { new Guid("f53d31b6-a49a-4088-a1c5-fcb55d39e416"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "214A", 10, true, false, false },
                    { new Guid("7569705b-9f99-4d18-ad82-bf420db56dea"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "203", 10, true, true, false },
                    { new Guid("c6be4ac9-e0d4-43ce-a7c9-4d9b941af74e"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "42", 13, false, false, true },
                    { new Guid("448742d4-b300-425d-9c54-7d848bc314e9"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), "206", 10, true, true, false },
                    { new Guid("5281b65e-13ba-4ef4-a909-6c5bdafc6f9c"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "41", 13, false, false, true },
                    { new Guid("4a72412c-adf5-4530-ad39-3908f30ba199"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), "41A", 13, true, false, true },
                    { new Guid("264a8c07-447a-4abb-bd2e-cbf59978c379"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "08", 12, true, true, true },
                    { new Guid("be135cfc-2d4c-4dbd-8b8f-57768c9f06ba"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "8B", 12, true, true, true },
                    { new Guid("cbcdf41d-5ca4-4d2d-9546-03e8da4a08ae"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "09", 11, true, true, true },
                    { new Guid("4b440316-38b3-4414-af93-dd9506ae8cb1"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "10", 11, true, true, true },
                    { new Guid("37a9d80a-6677-4b8b-8cfc-f0474c030bc0"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "11", 10, true, true, true },
                    { new Guid("6ce86894-8aa7-44d9-aeaf-b60c42490d60"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "13", 9, true, true, true },
                    { new Guid("d1687dae-4b4a-4385-a11c-a6c92300bef5"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "14", 9, false, true, true },
                    { new Guid("23a61fc0-60a6-4559-878d-95e91d1c8b41"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "15", 8, false, true, true }
                });

            migrationBuilder.InsertData(
                table: "Portas",
                columns: new[] { "PortaID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PortaNum", "PortaTempo", "Remoto", "Schengen", "Terminal" },
                values: new object[,]
                {
                    { new Guid("fec9a7fe-9c72-486b-85f4-7e1802bdaa91"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "15A", 8, true, true, true },
                    { new Guid("05ee5079-be52-4239-8a46-c8c676f0857b"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "16", 8, false, true, true },
                    { new Guid("b8cfba9e-66b1-4056-8d16-f30259b4aca0"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "16A", 8, true, true, true },
                    { new Guid("e3b43f27-6ee7-431a-b18a-3c46431f923b"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "17", 7, false, true, true },
                    { new Guid("95a14182-ad3d-43d9-b6b9-81b2587e4c27"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "17A", 7, true, true, true },
                    { new Guid("9d822e83-20f4-4fe7-80fb-2c01654de0f6"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), "12", 10, true, true, true },
                    { new Guid("84914c0e-eba9-4310-81f1-f83300c2342f"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18A", 7, true, true, true },
                    { new Guid("fcc7e44c-2ae3-4cdf-92f3-ac15c5639c75"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "27", 12, true, false, true },
                    { new Guid("ab5ed56a-6e20-47a9-acac-0549fefdb250"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18", 7, true, true, true },
                    { new Guid("034e4412-d64c-4b45-a525-34207a815e6d"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "26", 12, false, false, true },
                    { new Guid("c4c5684a-8722-4a6e-b834-b169fee3eb32"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "25", 7, false, true, true },
                    { new Guid("f503e602-5f25-4b2a-830c-53ac19fa03eb"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "24", 7, false, true, true },
                    { new Guid("33e80fcf-df04-4cba-bf3d-790dbf646512"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "23", 5, false, true, true },
                    { new Guid("b9d30135-a60b-4ec5-8ea8-fdd45ca8a9fd"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "23A", 5, true, true, true },
                    { new Guid("b81da84c-17b1-4842-bb62-df6dcd1ada7d"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "22", 5, false, true, true },
                    { new Guid("1d052e7b-d56d-4517-93e3-f7471a3600ce"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "21", 6, true, true, true },
                    { new Guid("4fa19a5e-e284-4f51-b6db-e3ca7fc04a6f"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "20", 8, true, true, true },
                    { new Guid("e7212ff0-8ce8-4ae7-83a3-c1c445290083"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "19", 8, true, true, true },
                    { new Guid("030f476d-6c6e-46cf-8989-e84f67f582b8"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "18B", 7, true, true, true },
                    { new Guid("927e0a03-b4aa-4b60-a5b7-c894779b70c7"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), "22A", 5, true, true, true }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("3f9e0fa6-f9e5-4cb1-9ba2-7a8654a5228b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 503 },
                    { new Guid("b8805740-0c42-4bdc-bcf2-7891418e9233"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 424 },
                    { new Guid("01c39a6f-b075-42bc-be2e-a0bb4a50883e"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 502 },
                    { new Guid("1a4807d0-7572-4c11-b136-a765435f4ffa"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 501 },
                    { new Guid("2b067f5f-691b-4d16-96ef-ee694b5e23fa"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 504 },
                    { new Guid("c14e8e5f-4e1e-4c7d-820c-3eff5394bc07"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 426 },
                    { new Guid("e12b1e8e-a57d-4468-a9fe-1448a01daec1"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 425 },
                    { new Guid("2121fc4a-831b-4102-94c5-8b6a4208b6c9"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 423 },
                    { new Guid("8f9e34e1-62e2-4c62-88d3-a35910df1ae3"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 413 },
                    { new Guid("a4fa10ca-a2c0-429e-85b7-80ac96439440"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 421 },
                    { new Guid("ed7f11ac-bee7-4e71-93b2-f631b76e4a82"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 416 },
                    { new Guid("01fff975-c9b9-4a2e-b4d3-d69d20a70fef"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 415 },
                    { new Guid("dca5cf97-ffbc-41da-8e6f-37c37f427555"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 414 },
                    { new Guid("a2365b3c-aefc-4f7c-bc75-107098138520"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 412 },
                    { new Guid("ce5893db-3ef0-48a3-821b-6dfb66910e1b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 411 },
                    { new Guid("5a8427e5-bfba-40f4-8041-0508f8b25abc"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 505 },
                    { new Guid("75abc190-e616-406a-9c3b-e6a60757a09d"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 405 },
                    { new Guid("9e099bb7-e0e6-441f-9cce-6bf21d4ade22"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 422 },
                    { new Guid("54216828-bb85-40ea-beca-c54ca17f1e30"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 506 },
                    { new Guid("b2987868-9db0-44ce-9838-bfdacde0edaa"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 706 },
                    { new Guid("2cb114d4-7e08-49a3-9396-387153b4c275"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 602 },
                    { new Guid("712ca9f9-8106-41e0-b32e-3b3fc8a06ef3"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 404 }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("dcae6a3a-4ab0-43b9-8829-6ce681b9f507"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 804 },
                    { new Guid("78d5fdfd-54ef-45ff-84ac-07eb3649eadb"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 803 },
                    { new Guid("2779ccc7-26bb-450b-b6b8-138e951881f9"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 802 },
                    { new Guid("0f0c8612-1a92-494e-9256-d328e9fbecfa"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 801 },
                    { new Guid("0eb3c60a-4750-47e4-9e89-6cd602839535"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 705 },
                    { new Guid("6969a88a-d4c2-4fee-b091-21992d0d0478"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 704 },
                    { new Guid("b8c809e5-0255-4f18-9234-0d28dcaaaa31"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 703 },
                    { new Guid("84bf07d2-8a49-45ed-9d40-caa1db86a5fa"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 702 },
                    { new Guid("ae3b6013-0858-4b9a-bc7a-4788357261e2"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 701 },
                    { new Guid("4c250576-bafb-4bff-86f5-702874612073"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 609 },
                    { new Guid("461779e5-3cf3-4cb9-854b-4fc91f5bce6b"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 608 },
                    { new Guid("9a681ddc-6787-462d-806c-469a5ca918ea"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 607 },
                    { new Guid("d3a1e72e-0cc8-4a03-a7b8-862c9d83fb61"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 606 },
                    { new Guid("77f4317f-4dac-4969-bec9-12556bea1c2f"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 605 },
                    { new Guid("2287dfe8-4b8b-4fe0-a25a-ac42147fa529"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 604 },
                    { new Guid("af1dcd9a-d466-4bc7-8127-6caf6fee1d38"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 603 },
                    { new Guid("f078f70c-7abb-44a7-ae45-f009d63e8b18"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("0fd79a44-d4d8-414e-bf1f-2cdb9ca07875"), true, 601 },
                    { new Guid("21d4592f-a407-48cc-85ce-a7619676af29"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 403 },
                    { new Guid("b3cdb364-d717-4ce5-b339-2eee959a25db"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 122 },
                    { new Guid("365d326f-b222-4dca-9d98-fe39e00d85b8"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 401 },
                    { new Guid("cacef562-7de8-41c1-8ec0-4bb7a39d6787"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 143 },
                    { new Guid("a6b78fb5-021e-41cb-a897-bf527ae17212"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 142 },
                    { new Guid("cd5ac41a-70ad-4556-b894-f668b681cfdd"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 141 },
                    { new Guid("3d56e45c-44ed-4a83-8edf-c05c46a2b794"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 126 },
                    { new Guid("61a15e8b-ee2f-46f1-911f-4ea2a72bc42e"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 125 },
                    { new Guid("6016bddc-6c6e-4591-ac3d-b59ae456b342"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 124 },
                    { new Guid("f599d0d1-8363-4f32-86ca-bdb0afe4411a"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 123 },
                    { new Guid("d0a0b444-bf00-416e-adb0-b17bb8927c92"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 805 },
                    { new Guid("a65c33f3-42eb-40b8-a2ff-a17ae92710cf"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 117 },
                    { new Guid("24d1dc54-5455-4644-90a0-d072a6dd6e8d"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 116 },
                    { new Guid("0c89fcc9-64d3-4d2c-aaf6-66cee77beec5"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 115 },
                    { new Guid("cf3ce64d-809d-455c-830d-e8670ce5c248"), null, null, null, null, new Guid("04cb8c84-8da7-423d-9033-ba23c80ba409"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 114 },
                    { new Guid("8f896593-9cbb-4807-8794-f23f8bdc00f8"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 108 },
                    { new Guid("9a1b5da6-d63d-4563-ae89-b7e45ba33128"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 107 },
                    { new Guid("98638772-bc63-4058-9910-ccefddad1abf"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 106 },
                    { new Guid("f1ae7610-5993-4369-b60a-d0cc21b0d3ea"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 105 },
                    { new Guid("cfacfb82-6874-45c4-a983-1c942c5cd502"), null, null, null, null, new Guid("eea39faf-8802-4820-8c87-655d37f45741"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), true, 104 },
                    { new Guid("759e85b2-2e29-475d-8d53-4c4d48d12c9c"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 144 },
                    { new Guid("50bc103e-ab8c-4e8f-93a2-69afa567a5a4"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 402 },
                    { new Guid("297cd192-204f-470e-be9d-c8b7fe3ae410"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 145 },
                    { new Guid("be1e8366-52c5-4d4b-9241-63ac2b61e0da"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 147 },
                    { new Guid("8832e9ba-30a8-4f70-88cb-28e71924dbc9"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 302 }
                });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "StandId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "PierID", "PlataformaId", "Remoto", "StandN" },
                values: new object[,]
                {
                    { new Guid("2b621b72-0bf1-494f-b838-672ad7b6a347"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("e9fd1e37-5d1b-4c05-95b5-c916a2de0f03"), true, 301 },
                    { new Guid("bce403b3-9c20-4745-9127-0a249de320b3"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 225 },
                    { new Guid("2d4ec051-b3eb-45c6-bfa9-2e7378a91578"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 224 },
                    { new Guid("3b065a83-a585-4812-a65a-c90a7c8e69de"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 223 },
                    { new Guid("349c837a-794a-4a20-8172-9b5b392c43cb"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 222 },
                    { new Guid("ad8cb1ad-08f8-4e14-b249-9c3188aec84c"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("42e7fa31-ae4d-4e72-8e81-3248cc5a0301"), true, 221 },
                    { new Guid("3596e8fd-fef4-4f27-9f03-d4a5ca08c24c"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 209 },
                    { new Guid("19ce51f3-8fe8-49f6-b12e-77f2d69f4940"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 208 },
                    { new Guid("a509f976-c7fc-44c1-b953-9fed7637cb71"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 207 },
                    { new Guid("46d62559-5c02-4b86-9dd1-0fdd8c786fd2"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 206 },
                    { new Guid("65d61b71-be11-4a05-a687-630dddd4a8c3"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 205 },
                    { new Guid("03bad594-8be3-43bd-83b4-d38d4a864039"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 204 },
                    { new Guid("382171e0-a334-4887-b7bd-9a4afbc7186a"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 203 },
                    { new Guid("de445a40-9c03-46c1-99b2-afa7c89215a7"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 202 },
                    { new Guid("6f935da8-daae-4563-809e-8d74667113d6"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 201 },
                    { new Guid("e416880a-c92d-43a2-80b5-345d1d02d98c"), null, null, null, null, new Guid("3dd86690-5721-4331-8438-3aa673265b69"), new Guid("c266a749-4eef-4dad-b5c2-cbdbab48d458"), true, 200 },
                    { new Guid("080abf45-bac3-47ea-9b51-8a11667d7658"), null, null, null, null, new Guid("0503947c-33a0-4ab4-b120-bc88f7918a93"), new Guid("2038588c-1d02-483b-8474-01656bc1c5ce"), false, 146 },
                    { new Guid("2b279c5f-b2fd-4b92-abc4-07829bbd1bd6"), null, null, null, null, new Guid("bde32891-f337-44c8-b46b-9c911a42df3e"), new Guid("87ee6546-67a4-46a7-a898-1f264d8f0ea5"), true, 806 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portas_PierID",
                table: "Portas",
                column: "PierID");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_UhID1",
                table: "Salas",
                column: "UhID1");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_PierID",
                table: "Stands",
                column: "PierID");

            migrationBuilder.CreateIndex(
                name: "IX_Stands_PlataformaId",
                table: "Stands",
                column: "PlataformaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssistenciasPRMS");

            migrationBuilder.DropTable(
                name: "DadosAeroportos");

            migrationBuilder.DropTable(
                name: "Escalas");

            migrationBuilder.DropTable(
                name: "HistoricoAssistencias");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "Portas");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Stands");

            migrationBuilder.DropTable(
                name: "Piers");

            migrationBuilder.DropTable(
                name: "Plataformas");

            migrationBuilder.CreateTable(
                name: "RelatoriosDiarios",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumChegadas = table.Column<int>(type: "int", nullable: false),
                    NumPartidas = table.Column<int>(type: "int", nullable: false),
                    UhID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatoriosDiarios", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RelatoriosDiarios_Uhs_UhID",
                        column: x => x.UhID,
                        principalTable: "Uhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ambulift = table.Column<int>(type: "int", nullable: false),
                    AmbuliftOp = table.Column<int>(type: "int", nullable: false),
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VeiculoEletrico = table.Column<int>(type: "int", nullable: false),
                    VeiculoEletricoOp = table.Column<int>(type: "int", nullable: false),
                    Vta = table.Column<int>(type: "int", nullable: false),
                    VtaOp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Equipamentos_RelatoriosDiarios_RelatorioID",
                        column: x => x.RelatorioID,
                        principalTable: "RelatoriosDiarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorasExtra",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DC = table.Column<double>(type: "float", nullable: false),
                    DS = table.Column<double>(type: "float", nullable: false),
                    FuncaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Justificacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pnt = table.Column<int>(type: "int", nullable: false),
                    PrimeiraHora = table.Column<double>(type: "float", nullable: false),
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SegundaHora = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasExtra", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HorasExtra_Funcoes_FuncaoID",
                        column: x => x.FuncaoID,
                        principalTable: "Funcoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HorasExtra_RelatoriosDiarios_RelatorioID",
                        column: x => x.RelatorioID,
                        principalTable: "RelatoriosDiarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incumprimentos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aceites = table.Column<int>(type: "int", nullable: false),
                    AceitesMais15 = table.Column<int>(type: "int", nullable: false),
                    AceitesMenos15 = table.Column<int>(type: "int", nullable: false),
                    Imputados = table.Column<int>(type: "int", nullable: false),
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Respondidos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incumprimentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Incumprimentos_RelatoriosDiarios_RelatorioID",
                        column: x => x.RelatorioID,
                        principalTable: "RelatoriosDiarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChegadaCpnMais10Menos20 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMais20 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMais5Menos10 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMenos5 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMais15Menos20 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMais20Menos30 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMais30 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMenos15 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMais25Menos35 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMais35Menos45 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMais45 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMenos25 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMais10Menos20 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMais20Menos30 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMais30 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMenos10 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMais25Menos35 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMais35Menos45 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMais45 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMenos25 = table.Column<int>(type: "int", nullable: false),
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Slas_RelatoriosDiarios_RelatorioID",
                        column: x => x.RelatorioID,
                        principalTable: "RelatoriosDiarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Escalado = table.Column<int>(type: "int", nullable: false),
                    FuncaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Limitacoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manha = table.Column<int>(type: "int", nullable: false),
                    Noite = table.Column<int>(type: "int", nullable: false),
                    Pnt = table.Column<int>(type: "int", nullable: false),
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tarde = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Funcoes_FuncaoID",
                        column: x => x.FuncaoID,
                        principalTable: "Funcoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Staff_RelatoriosDiarios_RelatorioID",
                        column: x => x.RelatorioID,
                        principalTable: "RelatoriosDiarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2301D884-221A-4E7D-B509-0113DCC043E1",
                column: "ConcurrencyStamp",
                value: "2f048e5a-df75-45af-9fcf-3b18e763b179");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "78A7570F-3CE5-48BA-9461-80283ED1D94D",
                column: "ConcurrencyStamp",
                value: "84eefa69-7fcb-42aa-8b89-e4b255fcbcfb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7D9B7113-A8F8-4035-99A7-A20DD400F6A3",
                column: "ConcurrencyStamp",
                value: "9c16fb56-bfe4-4034-abf7-024d14a57de7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "064f9b20-cb50-4cf5-b741-f0b6610d943a", "AQAAAAEAACcQAAAAEIHumMYXfgLiAHQ5MQkg0YxWfvo0/TvKEF9j/G0Z/KGgWjg8klsmyIBjm/vcnfmTQw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_RelatorioID",
                table: "Equipamentos",
                column: "RelatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_HorasExtra_FuncaoID",
                table: "HorasExtra",
                column: "FuncaoID");

            migrationBuilder.CreateIndex(
                name: "IX_HorasExtra_RelatorioID",
                table: "HorasExtra",
                column: "RelatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_Incumprimentos_RelatorioID",
                table: "Incumprimentos",
                column: "RelatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_RelatoriosDiarios_UhID",
                table: "RelatoriosDiarios",
                column: "UhID");

            migrationBuilder.CreateIndex(
                name: "IX_Slas_RelatorioID",
                table: "Slas",
                column: "RelatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_FuncaoID",
                table: "Staff",
                column: "FuncaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RelatorioID",
                table: "Staff",
                column: "RelatorioID");
        }
    }
}
