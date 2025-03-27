using Microsoft.AspNetCore.Mvc;
using Mysistem.Infraestructura;
using Mysistem.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Mysistem.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmpleadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Empleado> GetEmpleados()
        {
            return _context.Empleados.ToList();
        }
    }
}
