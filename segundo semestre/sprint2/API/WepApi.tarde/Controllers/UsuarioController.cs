using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi.tarde.Domains;
using WepApi.tarde.Interfaces;
using WepApi.tarde.Repositories;

namespace WepApi.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioReponsitory _usuarioRepository;
        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpPost]

        public IActionResult Login (string Email, string Senha)
        {
            UsuarioDomain UsuarioBuscado = _usuarioRepository.Login(Email, Senha);
            try
            {
                if (UsuarioBuscado==null)
                {
                    return NotFound("Usuario nao encontrado, Email ou senha invalido");
                }

                return Ok(UsuarioBuscado);
            }
            catch (Exception ERRO)
            {

                return BadRequest(ERRO.Message);
            }
        }
    }
}
