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
        
       private FabricanteRepository _fabricante = new FabricanteRepository();

        /// <summary>
        /// Lista todos os Fabricantes da Base
        /// </summary>
        /// <returns>Uma lista com todos os Fabricantes da Base</returns>
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_fabricante.Listar());
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Cadastra um novo fabricante na base
        /// </summary>
        /// <param name="fabricante">dadods do objeto fabricante</param>
        /// <returns>status ok</returns>
        [HttpPost]
        public IActionResult Cadastrar(Fabricante fabricante)
        {
            try
            {
                _fabricante.Cadastrar(fabricante);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpPatch]
        public IActionResult Atualizar(Guid id, Fabricante fabricante)
        {
            try
            {
                _fabricante.Atualizar(id, fabricante);

                return Ok();
            } 
            catch (Exception)
            {

                throw;
            }

        }



        /// <summary>
        /// Deleta um fabricante da base
        /// </summary>
        /// <param name="id"> id o fabricante a ser apagado</param>
        /// <returns>status ok</returns>
        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _fabricante.Deletar(id);

                return Ok();

               
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Busca um fabricante pelo id
        /// </summary>
        /// <param name="id">Id do fabricante buscado</param>
        /// <returns>Fabricante referente ao id informado</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id) 
        {
            try
            {
                return Ok(_fabricante.BuscarPorId(id)); 
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
