using Atencion.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Domain.Model;
using Travel.Domain.UseCase;
using Travel.DrivenAdapters.SqlServer;

namespace Travel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeguimientoController: Controller
    {
        private readonly AtencionDbContext _inventarioDbContext;

        public SeguimientoController(AtencionDbContext inventarioDbContext)
        {
            _inventarioDbContext = inventarioDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSeguimiento()
        {
            var seguimiento = await _inventarioDbContext.Seguimiento.ToListAsync();
            return Ok(seguimiento);
        }

        [HttpPost]
        public async Task<IActionResult> AddSeguimiento([FromBody] Seguimiento seguimientoRequest)
        {
            seguimientoRequest.Id = 0;

            await _inventarioDbContext.Seguimiento.AddAsync(seguimientoRequest);
            await _inventarioDbContext.SaveChangesAsync();

            return Ok(seguimientoRequest);
        }
    }
}
