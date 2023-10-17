using Microsoft.AspNetCore.Mvc;
using veiculos.Domains;
using veiculos.Interfaces;
using veiculos.Repositories;

namespace veiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class VeiculoController : ControllerBase
    {
        /// <summary>
        /// instancia de objeto q permite o acessso aos metodos da clase VeiculoRepository
        /// </summary>
        VeiculoRepository veiculo = new VeiculoRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(veiculo.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


    }
}
