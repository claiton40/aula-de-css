using Microsoft.AspNetCore.Mvc;
using veiculos.Domains;
using veiculos.Repositories;

namespace veiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FabricanteController : ControllerBase
    {
        FabricanteRepository fabricante = new FabricanteRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(fabricante.Listar());
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id) 
        {
            try
            {
                return Ok(fabricante.BuscarPorId(id)); 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
