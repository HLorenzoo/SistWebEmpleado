
using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleadosContext : DbContext
    {
        public DBEmpleadosContext(DbContextOptions<DBEmpleadosContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}