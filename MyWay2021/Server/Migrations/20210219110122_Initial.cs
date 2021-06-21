using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWay2021.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Funcoes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcoes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Justificacoes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Justificacoes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposAssistencia",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposAssistencia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposMensagem",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMensagem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoVoos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVoos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uhs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IATA = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CodAeroporto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NomeAeroporto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uhs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Formandos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FuncaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UhID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formandos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Formandos_Funcoes_FuncaoID",
                        column: x => x.FuncaoID,
                        principalTable: "Funcoes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Formandos_Uhs_UhID",
                        column: x => x.UhID,
                        principalTable: "Uhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatoriosDiarios",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UhID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumPartidas = table.Column<int>(type: "int", nullable: false),
                    NumChegadas = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "UsersUhs",
                columns: table => new
                {
                    UhID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersUhs", x => new { x.UserId, x.UhID });
                    table.ForeignKey(
                        name: "FK_UsersUhs_Uhs_UhID",
                        column: x => x.UhID,
                        principalTable: "Uhs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersUhs_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Vta = table.Column<int>(type: "int", nullable: false),
                    Ambulift = table.Column<int>(type: "int", nullable: false),
                    VeiculoEletrico = table.Column<int>(type: "int", nullable: false),
                    VtaOp = table.Column<int>(type: "int", nullable: false),
                    AmbuliftOp = table.Column<int>(type: "int", nullable: false),
                    VeiculoEletricoOp = table.Column<int>(type: "int", nullable: false)
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
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pnt = table.Column<int>(type: "int", nullable: false),
                    PrimeiraHora = table.Column<double>(type: "float", nullable: false),
                    SegundaHora = table.Column<double>(type: "float", nullable: false),
                    DC = table.Column<double>(type: "float", nullable: false),
                    DS = table.Column<double>(type: "float", nullable: false),
                    Justificacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Imputados = table.Column<int>(type: "int", nullable: false),
                    Respondidos = table.Column<int>(type: "int", nullable: false),
                    Aceites = table.Column<int>(type: "int", nullable: false),
                    AceitesMenos15 = table.Column<int>(type: "int", nullable: false),
                    AceitesMais15 = table.Column<int>(type: "int", nullable: false)
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
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartidaCpnMenos10 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMais10Menos20 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMais20Menos30 = table.Column<int>(type: "int", nullable: false),
                    PartidaCpnMais30 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMenos5 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMais5Menos10 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMais10Menos20 = table.Column<int>(type: "int", nullable: false),
                    ChegadaCpnMais20 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMenos25 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMais25Menos35 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMais35Menos45 = table.Column<int>(type: "int", nullable: false),
                    PartidaSpnMais45 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMenos15 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMais15Menos20 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMais20Menos30 = table.Column<int>(type: "int", nullable: false),
                    ChegadaSpnMais30 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMenos25 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMais25Menos35 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMais35Menos45 = table.Column<int>(type: "int", nullable: false),
                    Menos90MinMais45 = table.Column<int>(type: "int", nullable: false)
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
                    RelatorioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncaoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pnt = table.Column<int>(type: "int", nullable: false),
                    Escalado = table.Column<int>(type: "int", nullable: false),
                    Manha = table.Column<int>(type: "int", nullable: false),
                    Tarde = table.Column<int>(type: "int", nullable: false),
                    Noite = table.Column<int>(type: "int", nullable: false),
                    Limitacoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Nome" },
                values: new object[,]
                {
                    { new Guid("1400f058-b85c-47aa-96f8-bccab867d930"), null, null, null, null, "ASSISTENTE" },
                    { new Guid("32d5f978-8841-4f41-9876-9d3bbc0d42ea"), null, null, null, null, "COORDENADOR" },
                    { new Guid("d0704bcc-0316-438e-9c83-408bc3130754"), null, null, null, null, "SUB. COORDENADOR" },
                    { new Guid("1cd22050-9302-46f8-bab3-a92963ea7086"), null, null, null, null, "ADMINISTRATIVO" },
                    { new Guid("7978ce01-a193-47c8-993f-22ca803475da"), null, null, null, null, "SUPERVISOR" },
                    { new Guid("bae2d2f8-ca3a-4864-bce9-c50c784556dd"), null, null, null, null, "ALOCADOR" },
                    { new Guid("cf120207-b910-4c05-926d-1d7aea125b81"), null, null, null, null, "MOTORISTA" },
                    { new Guid("3bf6fda6-ff6c-4dfc-9b03-22fd59419ba6"), null, null, null, null, "MOTORISTA (AMBULIFT)" }
                });

            migrationBuilder.InsertData(
                table: "Justificacoes",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Nome" },
                values: new object[,]
                {
                    { new Guid("b8884316-1b76-4fcc-a217-d4f855254837"), null, null, null, null, "INCUMPRIMENTO NÃO NOTIFICADA" },
                    { new Guid("77f61289-8ea8-4862-bc5d-b19093636140"), null, null, null, null, "INCUMPRIMENTO NOTIFICADA" },
                    { new Guid("0267e756-9520-4c13-8ff9-33c2232605f9"), null, null, null, null, "ACIDENTE DE TRABALHO" },
                    { new Guid("72c36203-f875-44e1-8536-c55b0c8980f5"), null, null, null, null, "ATRASO" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2301D884-221A-4E7D-B509-0113DCC043E1", "2f048e5a-df75-45af-9fcf-3b18e763b179", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Administrador", "ADMINISTRADOR" },
                    { "78A7570F-3CE5-48BA-9461-80283ED1D94D", "84eefa69-7fcb-42aa-8b89-e4b255fcbcfb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Consultor", "CONSULTOR" },
                    { "7D9B7113-A8F8-4035-99A7-A20DD400F6A3", "9c16fb56-bfe4-4034-abf7-024d14a57de7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Utilizador", "UTILIZADOR" }
                });

            migrationBuilder.InsertData(
                table: "TipoVoos",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Tipo" },
                values: new object[,]
                {
                    { new Guid("cd5d4ce2-f51e-4c93-a1ab-6b3e73688305"), null, null, null, null, "DEP" },
                    { new Guid("aaca62fc-8ad2-4a0a-a2ee-c1d94cd86700"), null, null, null, null, "ARR" }
                });

            migrationBuilder.InsertData(
                table: "TiposAssistencia",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Tipo" },
                values: new object[,]
                {
                    { new Guid("348ed92b-fc54-44cd-a760-817a41e22e1c"), null, null, null, null, "MAAS" },
                    { new Guid("e01f774e-67e0-44a1-8671-8f90af915eb3"), null, null, null, null, "DPNA" },
                    { new Guid("458fff44-5ec2-45b1-8b5d-2510b641cc91"), null, null, null, null, "DEAF" },
                    { new Guid("1b0cae90-9b19-49c4-9ddf-51d8d5577cc6"), null, null, null, null, "WCHR" },
                    { new Guid("d4d989d1-4b43-477c-8fa8-f09b891f8618"), null, null, null, null, "WCHC" },
                    { new Guid("7a86678b-64dd-4a5f-beac-13147a19de79"), null, null, null, null, "WCHS" },
                    { new Guid("57935f8b-8579-4a42-ae5e-2e62bbf169ca"), null, null, null, null, "BLIND" }
                });

            migrationBuilder.InsertData(
                table: "TiposMensagem",
                columns: new[] { "ID", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Tipo" },
                values: new object[,]
                {
                    { new Guid("2ec46bc8-ba5f-42a4-bddf-abe9f783d7a7"), null, null, null, null, "PAL" },
                    { new Guid("4742160c-7d2c-4215-b53e-8c10f97863ab"), null, null, null, null, "CAL" },
                    { new Guid("b5fe799e-3c53-4276-9d27-c5c9bfb95dbe"), null, null, null, null, "PSM" },
                    { new Guid("c283da42-5812-4cf3-ba2c-0cddae1edfa8"), null, null, null, null, "NET" },
                    { new Guid("2c8fb881-51fd-4a55-a86c-dbad23b30551"), null, null, null, null, "AD-HOC" }
                });

            migrationBuilder.InsertData(
                table: "Uhs",
                columns: new[] { "ID", "CodAeroporto", "CreatedAt", "CreatedBy", "IATA", "LastUpdatedAt", "LastUpdatedBy", "Nome", "NomeAeroporto" },
                values: new object[,]
                {
                    { new Guid("7b277149-86d7-4c19-816c-0e97e803f491"), "AFR", null, null, "FAO", null, null, "FARO", "Aeroporto de Faro" },
                    { new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"), "AHD", null, null, "LIS", null, null, "LISBOA", "Aeroporto Humberto Delgado" },
                    { new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"), "ASC", null, null, "OPO", null, null, "PORTO", "Aeroporto Francisco Sá Carneiro" },
                    { new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"), "ACR", null, null, "FNC", null, null, "FUNCHAL", "Aeroporto Cristiano Ronaldo" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "B22698B8-42A2-4115-9631-1C2D1E2AC5F7", 0, "064f9b20-cb50-4cf5-b741-f0b6610d943a", "rui.santos@portway.pt", true, false, null, "Rui Pereira", "RUI.SANTOS@PORTWAY.PT", "RAPEREIRA", "AQAAAAEAACcQAAAAEIHumMYXfgLiAHQ5MQkg0YxWfvo0/TvKEF9j/G0Z/KGgWjg8klsmyIBjm/vcnfmTQw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "rapereira" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2301D884-221A-4E7D-B509-0113DCC043E1", "B22698B8-42A2-4115-9631-1C2D1E2AC5F7" });

            migrationBuilder.InsertData(
                table: "UsersUhs",
                columns: new[] { "UhID", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"), new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"), null },
                    { new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"), new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"), null },
                    { new Guid("7b277149-86d7-4c19-816c-0e97e803f491"), new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"), null },
                    { new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"), new Guid("b22698b8-42a2-4115-9631-1c2d1e2ac5f7"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_RelatorioID",
                table: "Equipamentos",
                column: "RelatorioID");

            migrationBuilder.CreateIndex(
                name: "IX_Formandos_FuncaoID",
                table: "Formandos",
                column: "FuncaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Formandos_UhID",
                table: "Formandos",
                column: "UhID");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersUhs_UhID",
                table: "UsersUhs",
                column: "UhID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersUhs_UserId1",
                table: "UsersUhs",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "Formandos");

            migrationBuilder.DropTable(
                name: "HorasExtra");

            migrationBuilder.DropTable(
                name: "Incumprimentos");

            migrationBuilder.DropTable(
                name: "Justificacoes");

            migrationBuilder.DropTable(
                name: "Slas");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "TiposAssistencia");

            migrationBuilder.DropTable(
                name: "TiposMensagem");

            migrationBuilder.DropTable(
                name: "TipoVoos");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UsersUhs");

            migrationBuilder.DropTable(
                name: "Funcoes");

            migrationBuilder.DropTable(
                name: "RelatoriosDiarios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Uhs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "B22698B8-42A2-4115-9631-1C2D1E2AC5F7");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "AspNetUserClaims",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "AspNetRoleClaims",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
