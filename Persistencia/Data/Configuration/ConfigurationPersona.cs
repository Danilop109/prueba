using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ConfigurationPersona :  IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.Property(n=> n.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(n=> n.Apellido)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(n=> n.Edad)
            .HasColumnType("int");
            
            builder.HasOne(p => p.TipoNomina)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoFk);

            builder.HasOne(p => p.Equipo)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdEquipoFk);
            
            builder.HasOne(p => p.Jugador)
            .WithOne(p => p.Persona)
            .HasForeignKey<Jugador>(p => p.IdPersonaFk)
            .IsRequired();
        }
    }
}