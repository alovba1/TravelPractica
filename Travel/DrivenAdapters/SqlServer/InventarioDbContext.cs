using Microsoft.EntityFrameworkCore;
using Travel.Domain.Model;

namespace Travel.DrivenAdapters.SqlServer
{
    public class InventarioDbContext: DbContext
    {
        public InventarioDbContext(DbContextOptions options):base(options) 
        {
        }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }

    }
}
