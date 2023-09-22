using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entity;
    public class TipoNomina : BaseEntity
    {
        public string NombreTipo { get; set; }
        public ICollection<Persona> Personas { get; set; }
    }
