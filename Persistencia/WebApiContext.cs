using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dominio.Entity;
using Microsoft.EntityFrameworkCore;

namespace Persistencia;
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Posicion> Posiciones { get; set; }
        public DbSet<TipoNomina> TipoNominas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
