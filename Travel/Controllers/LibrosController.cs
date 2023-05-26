using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Domain.Model;
using Travel.Domain.UseCase;
using Travel.DrivenAdapters.SqlServer;

namespace Travel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : Controller
    {
        private readonly InventarioDbContext _inventarioDbContext;
        public LibrosController(InventarioDbContext inventarioDbContext)
        {
            _inventarioDbContext = inventarioDbContext;
        }
        /** Método encargado de listar los Libros
        * @return Lista <Libros>
        * @autor Alberto Ovalle
        */
        [HttpGet]
        public async Task<IActionResult> GetAllLibros()
        {
            var libros = await _inventarioDbContext.Libros.ToListAsync();       
            return Ok(libros);
        }

        /** Método encargado de Guardar los Libros
        * @return objeto Libros
        * @autor Alberto Ovalle
        */

        [HttpPost]
        public async Task<IActionResult> AddLibros([FromBody] Libros librosRequest) 
        {
            librosRequest.Id = 0;

            await _inventarioDbContext.Libros.AddAsync(librosRequest);
            await _inventarioDbContext.SaveChangesAsync();
            
            return Ok(librosRequest);
        }
    }
}
