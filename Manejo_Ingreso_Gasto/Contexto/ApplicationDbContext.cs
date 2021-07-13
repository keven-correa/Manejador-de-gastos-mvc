using Manejo_Ingreso_Gasto.Models;
using Microsoft.EntityFrameworkCore;

namespace Manejo_Ingreso_Gasto.Contexto
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<IngresoGasto> IngresoGastos { get; set; }
    }
}
