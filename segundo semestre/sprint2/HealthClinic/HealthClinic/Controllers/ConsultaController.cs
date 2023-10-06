using HealthClinic.Domains;
using HealthClinic.Interfaces;
using HealthClinic.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }
        /// <summary>
        /// Lista todas as consultas
        /// </summary>
        /// <returns>Lista todas as consultas</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_consultaRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        /// <summary>
        /// Pesquisa a consulta por ID
        /// </summary>
        /// <param name="id">Informe o Id da Consulta</param>
        /// <returns>Pesquisa a consulta por ID</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_consultaRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Cadastrar nova Consulta
        /// </summary>
        /// <param name="consulta"> Informe os dados da consulta</param>
        /// <returns>Cadastrar nova Consulta</returns>
        [HttpPost]
        public IActionResult Post(Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta); ;

                return StatusCode(201, consulta);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Deletar uma Consulta
        /// </summary>
        /// <param name="id">Informe o Id da Consulta</param>
        /// <returns>Deletar uma Consulta</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _consultaRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Atualiza o Prontuario do paciente a partir da consulta.
        /// </summary>
        /// <param name="id">Informe o Id da Consulta</param>
        /// <param name="consulta"> Descreva a evolução do Prontuario</param>
        /// <returns>Atualiza o Prontuario do paciente a partir da consulta.</returns>
        [HttpPatch]
        public IActionResult Patch(Guid id, string consulta)
        {
            try
            {
                _consultaRepository.Prontuario(id, consulta);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
