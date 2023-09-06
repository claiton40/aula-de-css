using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using inlock_games.Domains;
using inlock_games.Interfaces;
using inlock_games.Repositories;

namespace inlock_games.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UsuariosController : ControllerBase
    
    {
        private IUsuariosRepository _usuariosRepository;

        public UsuariosController()
        {
            _usuariosRepository = new UsuariosRepository();
        }

        [HttpPost]
        public IActionResult Login(UsuariosDomain NovoUsuario)
        {
            try
            {
                UsuariosDomain UsuarioBuscado = _usuariosRepository.Login(NovoUsuario.Email, NovoUsuario.Senha);
                if (UsuarioBuscado == null)
                {
                    return NotFound("Usuário não encontrado, email ou senha inválidos!");
                }

                var claims = new[]
             {
                    //formato da claim(tipo, valor)
                    new Claim(JwtRegisteredClaimNames.Jti, UsuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, UsuarioBuscado.Email),
                  

                    //existe a possibilidade de criar uma claim personalizada
                    new Claim("Claim Personalizada", "Valor Personalizado")
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}