using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Domain.Model;
using Travel.Domain.UseCase;
using Travel.DrivenAdapters.SqlServer;

namespace Travel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtencionController : Controller
    {
        private readonly AtencionDbContext _inventarioDbContext;
        public AtencionController(AtencionDbContext inventarioDbContext)
        {
            _inventarioDbContext = inventarioDbContext;
        }
        /** Método encargado de listar los 
        * @return Lista <>
        * @autor Alberto Ovalle
        */
        [HttpGet]
        public async Task<IActionResult> GetAllPersonas()
        {
            var persona = await _inventarioDbContext.Persona.ToListAsync();       
            return Ok(persona);
        }

        /** Método encargado de Guardar los 
        * @return objeto 
        * @autor Alberto Ovalle
        */

        [HttpPost]
        public async Task<IActionResult> AddPersonas([FromBody] Persona personaRequest) 
        {
            personaRequest.Id = 0;

            await _inventarioDbContext.Persona.AddAsync(personaRequest);
            await _inventarioDbContext.SaveChangesAsync();
            
            return Ok(personaRequest);
        }
    }
}
