using Persistencia;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ConfigurationEquipo : IEntityTypeConfiguration<Equipo>
    {
        public void Configure(EntityTypeBuilder<Equipo> builder)
        {
            builder.ToTable("equipo");

            builder.Property(n=> n.NombrEquipo)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Pais)
            .WithMany(p => p.Equipos)
            .HasForeignKey(p => p.IdPaisFk);
        }
    }
}
