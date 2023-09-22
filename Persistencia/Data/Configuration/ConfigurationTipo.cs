using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ConfigurationTipo : IEntityTypeConfiguration<TipoNomina>
    {
        public void Configure(EntityTypeBuilder<TipoNomina> builder)
        {
            builder.ToTable("tipoNomina");

            builder.Property(n => n.NombreTipo)
            .IsRequired()
            .HasMaxLength(20);
        }
    }
}