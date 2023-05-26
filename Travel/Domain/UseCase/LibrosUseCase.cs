using Microsoft.AspNetCore.Mvc;
using Travel.Domain.Model;
using Travel.DrivenAdapters.SqlServer;
using Microsoft.EntityFrameworkCore;
namespace Travel.Domain.UseCase
{
    public class LibrosUseCase
    {
        private readonly InventarioDbContext _inventarioDbContext;
        public async void AdLibros([FromBody] Libros librosRequest)
        {
            
            
        }
    }
}
