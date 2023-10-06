using HealthClinic.Domains;
using HealthClinic.Interfaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MedicoController: ControllerBase
    {
        private IMedicoRepository _medicoRepository { get; set; }

        public MedicoController()
        {
            _medicoRepository = new MedicoRepository();
        }

        /// <summary>
        /// Lista todos o Medicos cadastrados
        /// </summary>
        /// <returns>Lista todos o Medicos cadastrados</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Pesquisa Medico por ID
        /// </summary>
        /// <param name="id">Informe o ID</param>
        /// <returns>Pesquisa Medico por ID</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_medicoRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Cadastra um novo Medico
        /// </summary>
        /// <param name="medico">Informe os dados do Medico</param>
        /// <returns>Cadastra um novo Medico</returns>
        [HttpPost]
        public IActionResult Post(Medico medico)
        {
            try
            {
                _medicoRepository.Cadastrar(medico);

                return StatusCode(201, medico);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
