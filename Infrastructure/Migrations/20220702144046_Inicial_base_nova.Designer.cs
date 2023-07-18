﻿// <auto-generated />
using System;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20220702144046_Inicial_base_nova")]
    partial class Inicial_base_nova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("USR_CEP");

                    b.Property<string>("CPF")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("USR_CPF");

                    b.Property<string>("Celular")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("USR_CELULAR");

                    b.Property<string>("ComplementoEndereco")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("USR_COMPLEMENTO_ENDERECO");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Endereco")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("USR_ENDERECO");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("USR_ESTADO");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("USR_IDADE");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("USR_NOME");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("USR_TELEFONE");

                    b.Property<int?>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("USR_TIPO");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Entities.Entities.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("COM_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataCompra")
                        .HasColumnType("datetime2")
                        .HasColumnName("COM_DATA_COMPRA");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("COM_ESTADO");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TB_COMPRA");
                });

            modelBuilder.Entity("Entities.Entities.CompraUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CUS_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int")
                        .HasColumnName("CUS_ESTADO");

                    b.Property<int>("IdCompra")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QtdCompra")
                        .HasColumnType("int")
                        .HasColumnName("CSU_QTD");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("UserId");

                    b.ToTable("TB_COMPRA_USUARIO");
                });

            modelBuilder.Entity("Entities.Entities.LogSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JsonInformacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOG_JSONINFORMACAO");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOG_ACTION");

                    b.Property<string>("NomeController")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOG_CONTROLLER");

                    b.Property<int>("TipoLog")
                        .HasColumnType("int")
                        .HasColumnName("LOG_TIPOLOG");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TB_LOGSISTEMA");
                });

            modelBuilder.Entity("Entities.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PRD_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("PRD_DATA_ALTERACAO");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("PRD_DATA_CADASTRO");

                    b.Property<string>("Descricao")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("PRD_DESCRICAO");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit")
                        .HasColumnName("PRD_ESTADO");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PRD_NOME");

                    b.Property<int>("IdPromocao")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasColumnName("ID_PROMO");

                    b.Property<string>("Promocao")
                        .HasMaxLength(20000)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PRD_PROMOCAO");

                    b.Property<string>("Observacao")
                        .HasMaxLength(20000)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PRD_OBSERVACAO");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("int")
                        .HasColumnName("PRD_QTD_ESTOQUE");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PRD_URL");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PRD_VALO");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Entities.Entities.Compra", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Entities.Entities.CompraUsuario", b =>
                {
                    b.HasOne("Entities.Entities.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId");

                    b.HasOne("Entities.Entities.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Compra");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Entities.Entities.LogSistema", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Entities.Entities.Produto", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
