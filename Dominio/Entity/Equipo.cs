using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entity;
    public class Equipo : BaseEntity
    {
        public string NombrEquipo { get; set; }
        public int IdPaisFk { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
