using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.inlock.tarde.Domains;
using webapi.inlock.tarde.Interface;
using webapi.inlock.tarde.Repository;

namespace webapi.inlock.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EstudioController : ControllerBase
    {
        private IEstudioRepository _estudioRepository;

        public EstudioController()
        {
            _estudioRepository = new EstudioRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_estudioRepository.Listar());
            }
            catch(Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("ListarComJogo")]
        public IActionResult GetWithGames()
        {
            try
            {
                return Ok(_estudioRepository.ListraComJogos());
            }
            catch (Exception)
            {
                throw new Exception("Falhou");
            }
        }

        [HttpDelete]

        public IActionResult Delete(Guid Id) 
        {
            try
            {
                _estudioRepository.Deletar(Id);

                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]

        public IActionResult Post(Estudio estudio)

        {
            _estudioRepository.Cadastrar(estudio);

            estudio.IdEstudio = Guid.NewGuid();
            
            return Ok(estudio);
        }
        
    }
}
