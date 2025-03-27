using System;

namespace Mysistem.Domain.Entities // Esto lo dejaremos igual
{
    public class Empleado // Cambia 'internal' por 'public'
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}
