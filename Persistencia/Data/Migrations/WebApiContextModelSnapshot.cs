﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(WebApiContext))]
    partial class WebApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entity.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombrEquipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("equipo", (string)null);
                });

            modelBuilder.Entity("Dominio.Entity.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Dorsal")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPosicionFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk")
                        .IsUnique();

                    b.HasIndex("IdPosicionFk");

                    b.ToTable("jugador", (string)null);
                });

            modelBuilder.Entity("Dominio.Entity.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Entity.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipoFk");

                    b.HasIndex("IdTipoFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Dominio.Entity.Posicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePosicion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("posicion", (string)null);
                });

            modelBuilder.Entity("Dominio.Entity.TipoNomina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreTipo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("tipoNomina", (string)null);
                });

            modelBuilder.Entity("Dominio.Entity.Equipo", b =>
                {
                    b.HasOne("Dominio.Entity.Pais", "Pais")
                        .WithMany("Equipos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Entity.Jugador", b =>
                {
                    b.HasOne("Dominio.Entity.Persona", "Persona")
                        .WithOne("Jugador")
                        .HasForeignKey("Dominio.Entity.Jugador", "IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entity.Posicion", "Posicion")
                        .WithMany("Jugadores")
                        .HasForeignKey("IdPosicionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Posicion");
                });

            modelBuilder.Entity("Dominio.Entity.Persona", b =>
                {
                    b.HasOne("Dominio.Entity.Equipo", "Equipo")
                        .WithMany("Personas")
                        .HasForeignKey("IdEquipoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entity.TipoNomina", "TipoNomina")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("TipoNomina");
                });

            modelBuilder.Entity("Dominio.Entity.Equipo", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Entity.Pais", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Dominio.Entity.Persona", b =>
                {
                    b.Navigation("Jugador");
                });

            modelBuilder.Entity("Dominio.Entity.Posicion", b =>
                {
                    b.Navigation("Jugadores");
                });

            modelBuilder.Entity("Dominio.Entity.TipoNomina", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}