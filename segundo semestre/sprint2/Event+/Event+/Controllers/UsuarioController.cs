using Event_.Domains;
using Event_.Interfaces;
using Event_.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Event_.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        [Produces("application/json")]
        public class UsuarioController : ControllerBase
        {
            private readonly IUsuarioRepository _usuarioRepository;

            public UsuarioController()
            {
                _usuarioRepository = new UsuarioRepository();
            }

            [HttpPost]
            public IActionResult Post(Usuario usuario)
            {
                try
                {
                    _usuarioRepository.Cadastrar(usuario);

                    return StatusCode(201, usuario);
                }
                catch (Exception error)
                {
                    return BadRequest(error.Message);
                }
            }

        }
    }
