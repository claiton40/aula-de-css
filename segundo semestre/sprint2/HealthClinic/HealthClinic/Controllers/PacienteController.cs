using HealthClinic.Domains;
using HealthClinic.Interfaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PacienteController: ControllerBase
    {
        private IPacienteRepository _pacienteRepository { get; set; }

        public PacienteController()
        {
            _pacienteRepository = new PacienteRepository();
        }

        /// <summary>
        /// Pesquisa o Paciente pelo ID
        /// </summary>
        /// <param name="id">Pesquisa o Paciente pelo ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_pacienteRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Cadastra um novo Paciente
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns>Cadastra um novo Paciente</returns>
        [HttpPost]
        public IActionResult Post(Paciente paciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(paciente);

                return StatusCode(201, paciente);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



    }
}
