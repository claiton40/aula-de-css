using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq.Expressions;
using inlock_games.Domains;
using inlock_games.Interfaces;
using inlock_games.Repositories;

namespace inlock_games.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EstudiosController : ControllerBase
    {
        private IEstudiosRepository _estudioRepository { get; set; }

        public EstudiosController()
        {
            _estudioRepository = new EstudiosRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<EstudiosDomain> ListaEstudios = _estudioRepository.ListarTodos();
                return Ok(ListaEstudios);
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }
    }
}