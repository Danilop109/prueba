using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ConfigurationPosicion : IEntityTypeConfiguration<Posicion>
    {
        public void Configure(EntityTypeBuilder<Posicion> builder)
        {
            builder.ToTable("posicion");

            builder.Property(n => n.NombrePosicion)
            .IsRequired()
            .HasMaxLength(20);

        }
    }
}