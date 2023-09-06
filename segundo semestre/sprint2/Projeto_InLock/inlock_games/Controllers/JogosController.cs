using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using inlock_games.Domains;
using inlock_games.Interfaces;
using inlock_games.Repositories;


namespace inlock_games.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class JogosController : ControllerBase
    {
        private IJogosRepository _jogosRepository { get; set; }

        public JogosController()
        {
            _jogosRepository= new JogosRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<JogosDomain> ListaJogos = _jogosRepository.ListarTodos();

                return Ok(ListaJogos);
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }

        }
        
        [HttpPost]
        public IActionResult Post(JogosDomain NovoJogo)
        {
            try
            {
                _jogosRepository.Cadastrar(NovoJogo);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}