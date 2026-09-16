using Microsoft.EntityFrameworkCore;
using Tarea2.Models;

namespace Tarea2.Context
{
    public class EstudianteContext : DbContext
    {
        public EstudianteContext(DbContextOptions<EstudianteContext> options) : base(options)
        {

        }

        public DbSet<Estudiantes> estudiantes { get; set; }
    }
}
