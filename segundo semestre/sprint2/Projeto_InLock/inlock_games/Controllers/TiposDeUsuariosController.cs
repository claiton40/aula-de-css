using inlock_games.Domains;
using inlock_games.Interfaces;
using inlock_games.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace inlock_games.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class TiposDeUsuariosController : ControllerBase
    {
        private ITiposUsuariosRepository _tiposUsuariosRepository { get; set; }
        public TiposDeUsuariosController()
        {
            _tiposUsuariosRepository = new TiposUsuariosRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                List<TiposUsuariosDomain> LitaTipos = _tiposUsuariosRepository.ListarTodos();
                return Ok(LitaTipos);
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }
        }
}