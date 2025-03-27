using Microsoft.EntityFrameworkCore;
using Mysistem.Domain.Entities; // IMPORTANTE: Asegúrate de importar el namespace correcto

namespace Mysistem.Infraestructura
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
