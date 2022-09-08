﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal_MVC.Data;

#nullable disable

namespace ProyectoFinal_MVC.Migrations
{
    [DbContext(typeof(ProyectoFinal_MVCDbContext))]
    [Migration("20220908160758_Migracion1")]
    partial class Migracion1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProyectoFinal_MVC.Models.Construccion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmpresaConstructoraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("LugarDeConstruccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaConstructoraId");

                    b.ToTable("Contrucciones");
                });

            modelBuilder.Entity("ProyectoFinal_MVC.Models.EmpresaConstructora", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmpresaConstructoras");
                });

            modelBuilder.Entity("ProyectoFinal_MVC.Models.Trabajador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmpresaConstructoraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaDeNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeTrabajador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaConstructoraId");

                    b.ToTable("Trabajadores");
                });

            modelBuilder.Entity("ProyectoFinal_MVC.Models.Construccion", b =>
                {
                    b.HasOne("ProyectoFinal_MVC.Models.EmpresaConstructora", "EmpresaConstructora")
                        .WithMany("Construcciones")
                        .HasForeignKey("EmpresaConstructoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaConstructora");
                });

            modelBuilder.Entity("ProyectoFinal_MVC.Models.Trabajador", b =>
                {
                    b.HasOne("ProyectoFinal_MVC.Models.EmpresaConstructora", "EmpresaConstructora")
                        .WithMany("Trabajadores")
                        .HasForeignKey("EmpresaConstructoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaConstructora");
                });

            modelBuilder.Entity("ProyectoFinal_MVC.Models.EmpresaConstructora", b =>
                {
                    b.Navigation("Construcciones");

                    b.Navigation("Trabajadores");
                });
#pragma warning restore 612, 618
        }
    }
}
