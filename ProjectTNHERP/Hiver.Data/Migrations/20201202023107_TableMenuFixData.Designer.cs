﻿// <auto-generated />
using System;
using Hiver.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hiver.Data.Migrations
{
    [DbContext(typeof(HiverDbContext))]
    [Migration("20201202023107_TableMenuFixData")]
    partial class TableMenuFixData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hiver.Data.Entities.AppController", b =>
                {
                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Licensed")
                        .HasColumnType("bit");

                    b.HasKey("Controller", "Action");

                    b.ToTable("AppControllers");

                    b.HasData(
                        new
                        {
                            Controller = "User",
                            Action = "Index",
                            Description = "Quản lý User",
                            Licensed = true
                        },
                        new
                        {
                            Controller = "Home",
                            Action = "Index",
                            Description = "Trang Chủ",
                            Licensed = true
                        });
                });

            modelBuilder.Entity("Hiver.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            ConcurrencyStamp = "aac0753c-2f4a-41b0-a23c-38cfd96abd25",
                            Description = "Administrator role",
                            Name = "Administrator",
                            NormalizedName = "Cấp 1"
                        },
                        new
                        {
                            Id = new Guid("44694fab-619c-4bcc-a8a1-4247a17905f5"),
                            ConcurrencyStamp = "41cecef7-2e52-4bf3-a232-3eeed7871254",
                            Description = "BanHang",
                            Name = "BanHang",
                            NormalizedName = "Cấp 2"
                        },
                        new
                        {
                            Id = new Guid("80b0a1ac-d287-4ba3-92c4-51cbcea55920"),
                            ConcurrencyStamp = "d5ac458c-9b86-43e4-ab82-a67f9f082f21",
                            Description = "Mua hàng",
                            Name = "MuaHang",
                            NormalizedName = "Cấp 2"
                        },
                        new
                        {
                            Id = new Guid("2629553d-758a-460b-92cf-5c34b76a97a7"),
                            ConcurrencyStamp = "2b470e45-ff77-4ec7-90bb-22fb1bfcaf13",
                            Description = "Kho",
                            Name = "Kho",
                            NormalizedName = "Cấp 2"
                        },
                        new
                        {
                            Id = new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee"),
                            ConcurrencyStamp = "5a4da9a5-83ed-4846-a7fe-77cb8b5f1999",
                            Description = "Nhân Sự",
                            Name = "Nhansu",
                            NormalizedName = "Cấp 2"
                        });
                });

            modelBuilder.Entity("Hiver.Data.Entities.AppRoleController", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("AppRoleControllers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Action = "GetAllPaging",
                            AppUser = "admin",
                            Controller = "Users"
                        });
                });

            modelBuilder.Entity("Hiver.Data.Entities.AppRoleControllerGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Controller")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdRole")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleControllerGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Action = "Index",
                            Controller = "User",
                            IdRole = new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee")
                        },
                        new
                        {
                            Id = 2,
                            Action = "Delete",
                            Controller = "User",
                            IdRole = new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee")
                        },
                        new
                        {
                            Id = 3,
                            Action = "EDIT",
                            Controller = "User",
                            IdRole = new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee")
                        },
                        new
                        {
                            Id = 4,
                            Action = "DETAIL",
                            Controller = "User",
                            IdRole = new Guid("7feb5851-4244-4538-a6bd-3b98c18afeee")
                        });
                });

            modelBuilder.Entity("Hiver.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2d90f2af-3e1d-461e-a96d-b642d6fcd723",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyễn",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEKkCnPozPj9VrLLtIlIwX/M84Kc1D8AbsjobZy84+kkbc8j0xj0vdEgX0CMWFdWL6w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("a3335a51-c19b-4ec8-9dec-39ef33e69bf7"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a8ba170e-4d51-4113-b82f-1a7a8f1e43d8",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "it@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyễn",
                            LastName = "It",
                            LockoutEnabled = false,
                            NormalizedEmail = "it@gmail.com",
                            NormalizedUserName = "it",
                            PasswordHash = "AQAAAAEAACcQAAAAEB/qd4GQjUrv/PJi3VR2OnDb/IY/2W7AQggZqND19E19yY0wKGqKRRlH7FAxWnTllQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "it"
                        },
                        new
                        {
                            Id = new Guid("171f3098-762c-4b02-85c5-a687f6601de4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b9282e95-3415-4e05-a942-d6ae89e5f33f",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kho@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nguyễn",
                            LastName = "Kho",
                            LockoutEnabled = false,
                            NormalizedEmail = "kho@gmail.com",
                            NormalizedUserName = "kho",
                            PasswordHash = "AQAAAAEAACcQAAAAEPy00itHZFGtr1l1lsmUB4NetYy4Wbw9ekb98ibgHDZJIlaSOAObk4FuaT14m+JCKQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "kho"
                        });
                });

            modelBuilder.Entity("Hiver.Data.Entities.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("IconClass")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("MenuName")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("MenuOrder")
                        .HasColumnType("int");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("MenuID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            IsVisible = true,
                            MenuName = "Trang Chính",
                            MenuOrder = 1,
                            ParentID = -1,
                            Url = "/"
                        },
                        new
                        {
                            MenuID = 2,
                            IsVisible = true,
                            MenuName = "Kho",
                            MenuOrder = 1,
                            ParentID = -1,
                            Url = "/"
                        },
                        new
                        {
                            MenuID = 3,
                            IsVisible = true,
                            MenuName = "Nguyên Liệu",
                            MenuOrder = 1,
                            ParentID = 2,
                            Url = "/"
                        },
                        new
                        {
                            MenuID = 4,
                            IsVisible = true,
                            MenuName = "Thành Phẩm",
                            MenuOrder = 1,
                            ParentID = 2,
                            Url = "/"
                        },
                        new
                        {
                            MenuID = 5,
                            IsVisible = true,
                            MenuName = "Kinh Doanh",
                            MenuOrder = 1,
                            ParentID = -1,
                            Url = "/"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
