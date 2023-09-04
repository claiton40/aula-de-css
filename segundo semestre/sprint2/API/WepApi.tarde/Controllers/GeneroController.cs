using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WepApi.tarde.Domains;
using WepApi.tarde.Interfaces;
using WepApi.tarde.Repositories;

namespace WepApi.tarde.Controllers
{
    /// <summary>
    /// Essa route define que um rota de um requusicao sera no seguinte formato: Dominio/API/DominioController
    /// Ex: http://loclahost:5000/api/Genero
    /// </summary>
    [Route("api/[controller]")]
    /// <summary>
    /// Define que e um controlador de API
    [ApiController]
    /// <summary>
    /// Define o tipo de arquivo da api com Jason
    /// </summary>
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        //private GeneroRepository _generoRepository;

        /// <summary>
        /// Objeto que ira receber os metodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Estancia do obejto _GeneroRepository para que ahaj referencia aos metodos do repositorio
        /// </summary>
        public GeneroController()
        {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// endpoint que acessa o metodo de listar os generos e ele retorna uma lsiat de generos e um statuscode
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize] //precisa estar logado para acessar a rota
        public IActionResult Get()
        {
            try
            {
                //ceia uma lista para receber os generos
                List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();
                // retorna o staus code 200 e retorna a lista em formato JASON
                return Ok(listaGeneros);

            }
            catch (Exception erro)
            {
                //retirna um statuscode 400 bad request e a menssagem de erro
                return BadRequest(erro.Message);
            }

        }

        [HttpGet("Id")]
        public IActionResult GetById(int Id)
        {
            try
            {
                GeneroDomain GeneroBuscado = _generoRepository.BuscarPorId(Id);
               
                return Ok(GeneroBuscado);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }

        }

        [HttpPost]
        public IActionResult Post(GeneroDomain NovoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(NovoGenero);

                return Created("Objeto criado", NovoGenero);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            try
            {
                _generoRepository.Deletar(Id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }

    }
}
