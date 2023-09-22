using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entity;
    public class Pais : BaseEntity
    {
        public string NombrePais { get; set; }
        public ICollection<Equipo> Equipos { get; set; }
    }
