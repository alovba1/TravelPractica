using Atencion.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Travel.Domain.Model;

namespace Travel.DrivenAdapters.SqlServer
{
    public class AtencionDbContext: DbContext
    {
        public AtencionDbContext(DbContextOptions options):base(options) 
        {
        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Seguimiento> Seguimiento { get; set; }


    }
}
