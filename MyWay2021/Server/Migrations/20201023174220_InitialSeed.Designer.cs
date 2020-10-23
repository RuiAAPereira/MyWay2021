﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWay2021.Server.Data;

namespace MyWay2021.Server.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20201023174220_InitialSeed")]
    partial class InitialSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("MyWay2021.Server.Models.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "3b04aa8e-4307-4711-93a4-e2fb2f09f5a5",
                            ConcurrencyStamp = "c703f4c7-e0ed-4524-9fb8-d495f3e5361e",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "e7526d31-3669-4f80-8e85-046e272634b6",
                            ConcurrencyStamp = "1a9b9ecf-40f1-4801-a984-4445bc2b1be5",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("MyWay2021.Server.Models.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0985bd49-7728-4668-9952-6e27e5212779",
                            Email = "rui.santos@portway.pt",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Rui Pereira",
                            NormalizedEmail = "RUI.SANTOS@PORTWAY.PT",
                            NormalizedUserName = "RAPEREIRA",
                            PasswordHash = "AQAAAAEAACcQAAAAEK9oxRxsEji9BpEDLL5EwMNTFo3ZsVhz9hXDT+9sNzP9n1pQhQ55VzY7yt00BKRJeg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fc567917-1216-4d95-96d4-b134302e8ad9",
                            TwoFactorEnabled = false,
                            UserName = "RaPereira"
                        });
                });

            modelBuilder.Entity("MyWay2021.Server.Models.Identity.AppUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "ed3083c5-dada-44f6-8f3e-fec4c3c4477f",
                            RoleId = "e7526d31-3669-4f80-8e85-046e272634b6"
                        });
                });

            modelBuilder.Entity("MyWay2021.Server.Models.Identity.UserUh", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UhID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "UhID");

                    b.HasIndex("UhID");

                    b.HasIndex("UserId1");

                    b.ToTable("UsersUhs");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("807aeb52-f2d7-4152-8410-a668604a41d4")
                        },
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac")
                        },
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("7b277149-86d7-4c19-816c-0e97e803f491")
                        },
                        new
                        {
                            UserId = new Guid("ed3083c5-dada-44f6-8f3e-fec4c3c4477f"),
                            UhID = new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471")
                        });
                });

            modelBuilder.Entity("MyWay2021.Shared.Models.Tabelas.Uh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IATA")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastUpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("ID");

                    b.ToTable("Uhs");

                    b.HasData(
                        new
                        {
                            ID = new Guid("807aeb52-f2d7-4152-8410-a668604a41d4"),
                            IATA = "LIS",
                            Nome = "LISBOA"
                        },
                        new
                        {
                            ID = new Guid("7a525467-1367-4ddf-9802-6bc44ae695ac"),
                            IATA = "OPO",
                            Nome = "PORTO"
                        },
                        new
                        {
                            ID = new Guid("7b277149-86d7-4c19-816c-0e97e803f491"),
                            IATA = "FAO",
                            Nome = "FARO"
                        },
                        new
                        {
                            ID = new Guid("7f6e20bd-7106-4c6f-a23d-dde9b0a1e471"),
                            IATA = "FNC",
                            Nome = "FUNCHAL"
                        });
                });

            modelBuilder.Entity("MyWay2021.Server.Models.Identity.AppUserRole", b =>
                {
                    b.HasOne("MyWay2021.Server.Models.Identity.AppRole", "Role")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWay2021.Server.Models.Identity.AppUser", "User")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyWay2021.Server.Models.Identity.UserUh", b =>
                {
                    b.HasOne("MyWay2021.Shared.Models.Tabelas.Uh", "Uh")
                        .WithMany()
                        .HasForeignKey("UhID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWay2021.Server.Models.Identity.AppUser", "User")
                        .WithMany("UserUhs")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}
