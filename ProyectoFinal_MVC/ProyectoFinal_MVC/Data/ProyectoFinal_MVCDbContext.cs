using Microsoft.EntityFrameworkCore;
using ProyectoFinal_MVC.Models;

namespace ProyectoFinal_MVC.Data
{
    public class ProyectoFinal_MVCDbContext : DbContext
    {
        public DbSet<EmpresaConstructora> EmpresaConstructoras { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public ProyectoFinal_MVCDbContext(DbContextOptions<ProyectoFinal_MVCDbContext> options) : base(options)
        {

        }
    }
}
