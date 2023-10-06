using HealthClinic.Domains;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class EspecialidadeController : ControllerBase
    {
        private EspecialidadeRepository _especialidadeRepository { get; set; }

        public EspecialidadeController()
        {
            _especialidadeRepository = new EspecialidadeRepository();
        }

        /// <summary>
        /// Cadastrar no Especialidade
        /// </summary>
        /// <param name="especialidade">Informe o Nome da Especialidade</param>
        /// <returns>Cadastrar no Especialidade</returns>
        [HttpPost]
        public IActionResult Post(Especialidade especialidade)
        {
            try
            {
                _especialidadeRepository.Cadastrar(especialidade);

                return StatusCode(201, especialidade);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Pesquisa a Especialidade por ID.
        /// </summary>
        /// <param name="id"> Informe o Id da Especialidade</param>
        /// <returns>Pesquisa a Especialidade por ID.</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_especialidadeRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Lista todas as Especialidades
        /// </summary>
        /// <returns>Lista todas as Especialidades</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_especialidadeRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
