using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerDeEventos.Clases
{
    internal class Tarea
    {
        public string nombre { get; set; }
        public String Estado { get; set; }

        public readonly DateTime fechaCreación;

        public Tarea(string nombre, String Estado)
        {
            this.fechaCreación = DateTime.Now;
            this.nombre = nombre;   
            this.Estado = Estado;
        }
        
    }
}

