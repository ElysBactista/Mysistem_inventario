using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysistem.infraesttructura
{
    internal class Empleado
    {

        public int Id { get; set; }          // ID único del empleado
        public string Nombre { get; set; }   // Nombre del empleado
        public string Cargo { get; set; }   // Cargo del empleado
        public decimal salario { get; set; } // Salario del empleado
        public DateTime FechaIngreso { get; set; } // Fecha en que el empleado ingresó
    }
}

