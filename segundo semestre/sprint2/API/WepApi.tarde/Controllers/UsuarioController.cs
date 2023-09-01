using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        public IActionResult Login(UsuarioDomain Usuario)
        {
            UsuarioDomain UsuarioBuscado = _usuarioRepository.Login(Usuario.Email, Usuario.Senha);
            try
            {
                if (UsuarioBuscado == null)
                {
                    return NotFound("Usuario nao encontrado, Email ou senha invalido");
                }
                //caso encontre o usuario buscado, prossegue para criacao do token

                //dados que serao fornecidos no token(payload)
                var claims = new[]
                {
                    //formato de cada clain. Tipo e valor delas
                    new Claim(JwtRegisteredClaimNames.Jti, UsuarioBuscado.IdUsuario.ToString()),

                    new Claim(JwtRegisteredClaimNames.Email, UsuarioBuscado.Email),

                    new Claim(ClaimTypes.Role, UsuarioBuscado.Permissao),

                    new Claim("Claim Personalizada", "Valor Personalizado")
                };

                //definir de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    issuer: "webapi.filmes.tarde",

                    audience: "webapi.filmes.tarde",

                    claims: claims,

                    expires: DateTime.Now.AddMinutes(5),

                    signingCredentials: creds
                );
                //retronar ot tokem criado

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            };

               // return Ok(UsuarioBuscado);
            }
            catch (Exception ERRO)
            {

                return BadRequest(ERRO.Message);
            }
        }
    }
}
