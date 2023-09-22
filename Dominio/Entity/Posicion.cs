using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entity;
    public class Posicion : BaseEntity
    {
        public string NombrePosicion { get; set; }
        public ICollection<Jugador> Jugadores { get; set; }
        
    }
