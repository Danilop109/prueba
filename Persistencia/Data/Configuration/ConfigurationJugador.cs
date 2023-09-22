using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ConfigurationJugador : IEntityTypeConfiguration<Jugador>
    {
         public void Configure(EntityTypeBuilder<Jugador> builder)
        {
            builder.ToTable("jugador");

            builder.Property(n=> n.Dorsal)
            .HasColumnType("int");

            builder.HasOne(p => p.Posicion)
            .WithMany(p => p.Jugadores)
            .HasForeignKey(p => p.IdPosicionFk);

            // builder.HasOne(p => p.Persona)
            // .WithOne(p => p.Jugador)
            // .HasForeignKey<Jugador>(p => p.IdPersonaFk)
            // .IsRequired();
        }

    }
}