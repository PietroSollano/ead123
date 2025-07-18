using Microsoft.EntityFrameworkCore;
using ProjetoEad.Models; 

namespace ProjetoEad.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
