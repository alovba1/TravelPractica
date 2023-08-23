using Microsoft.AspNetCore.Mvc;
using Travel.Domain.Model;
using Travel.DrivenAdapters.SqlServer;
using Microsoft.EntityFrameworkCore;
namespace Travel.Domain.UseCase
{
    public class AtencionUseCase
    {
        private readonly AtencionDbContext _inventarioDbContext;
        public async void AdLibros([FromBody] Persona librosRequest)
        {
            
            
        }
    }
}
