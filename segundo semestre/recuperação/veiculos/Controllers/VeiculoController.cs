using Microsoft.AspNetCore.Mvc;
using veiculos.Domains;
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
        VeiculoRepository _veiculo = new VeiculoRepository();

        /// <summary>
        /// Cadastra um veiculo novo
        /// </summary>
        /// <param name="veiculo"> dados do objeto veiculo</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo)
        {
            try
            {
                _veiculo.Cadastrar(veiculo);

                return Ok(veiculo);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Deletar um veiculo da base
        /// </summary>
        /// <param name="id">Id do veuculo a ser deletado</param>
        /// <returns></returns>
        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _veiculo.Deletar(id);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// listar
        /// </summary>
        /// <returns>Lista de Veiculos</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_veiculo.Listar());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Busca veiculo com base no Id
        /// </summary>
        /// <param name="id"> informar o Id do veiculo a ser Buscado</param>
        /// <returns>Veiculo referente ao id buscado</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                return Ok(_veiculo.BuscarPorId(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
