﻿// <auto-generated />
using BDEcomSurUsuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BDEcomSurUsuarios.Migrations
{
    [DbContext(typeof(BDEcomSurUsuarioContext))]
    partial class BDEcomSurUsuarioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BDEcomSurUsuarios.BDPermisos", b =>
                {
                    b.Property<int>("fiIdPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fiIdPermiso"));

                    b.Property<string>("fiName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fiIdPermiso");

                    b.ToTable("BDPermisos");
                });

            modelBuilder.Entity("BDEcomSurUsuarios.BDRoles", b =>
                {
                    b.Property<int>("fiIdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fiIdRol"));

                    b.Property<string>("fiName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fiIdRol");

                    b.ToTable("BDRoles");
                });

            modelBuilder.Entity("BDEcomSurUsuarios.BDRolesPermisos", b =>
                {
                    b.Property<string>("fiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("fiIdPermiso")
                        .HasColumnType("int");

                    b.Property<int>("fiIdRol")
                        .HasColumnType("int");

                    b.HasKey("fiId");

                    b.HasIndex("fiIdPermiso");

                    b.HasIndex("fiIdRol");

                    b.ToTable("BDRolesPermisos");
                });

            modelBuilder.Entity("BDEcomSurUsuarios.BDUsuario", b =>
                {
                    b.Property<int>("fiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fiId"));

                    b.Property<string>("fcAmaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcApaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcCalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcColonia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcCorrero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcFechaCreacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcNumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fcPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fiIdRol")
                        .HasColumnType("int");

                    b.Property<int>("fiUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("fiId");

                    b.HasIndex("fiIdRol");

                    b.ToTable("BDUsuarios");
                });

            modelBuilder.Entity("BDEcomSurUsuarios.BDRolesPermisos", b =>
                {
                    b.HasOne("BDEcomSurUsuarios.BDPermisos", "BDPermisos")
                        .WithMany()
                        .HasForeignKey("fiIdPermiso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDEcomSurUsuarios.BDRoles", "BDRoles")
                        .WithMany()
                        .HasForeignKey("fiIdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BDPermisos");

                    b.Navigation("BDRoles");
                });

            modelBuilder.Entity("BDEcomSurUsuarios.BDUsuario", b =>
                {
                    b.HasOne("BDEcomSurUsuarios.BDRoles", "BDRoles")
                        .WithMany()
                        .HasForeignKey("fiIdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BDRoles");
                });
#pragma warning restore 612, 618
        }
    }
}