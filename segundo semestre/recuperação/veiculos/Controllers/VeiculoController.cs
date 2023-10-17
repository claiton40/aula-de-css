using Microsoft.AspNetCore.Mvc;
using veiculos.Domains;
using veiculos.Interfaces;
using veiculos.Repositories;

namespace veiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class VeiculoController: ControllerBase
    {
        private IVeiculoRepository _veiculoRepository { get; set; }

        public VeiculoController()
        {
            _veiculoRepository = new VeiculoRepository();
        }
        /// <summary>
        /// Lista todas as consultas
        /// </summary>
        /// <returns>Lista todas os Veiculos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_veiculoRepository.Listar());
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
        /// <returns>Pesquisa o veiculo por ID</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_veiculoRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Cadastrar nova Consulta
        /// </summary>
        /// <param name="veiculo"> Informe os dados da consulta</param>
        /// <returns>Cadastrar novo Veiculo</returns>
        [HttpPost]
        public IActionResult Post(Veiculo veiculo)
        {
            try
            {
                _veiculoRepository.Cadastrar(veiculo); ;

                return StatusCode(201, veiculo);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Deletar uma Consulta
        /// </summary>
        /// <param name="id">Informe o Id do Veiculo</param>
        /// <returns>Deletar um Veiculo</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _veiculoRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Atualizar o registro de um veiculo
        /// </summary>
        /// <param name="id">informe o ID do Veiculo</param>
        /// <param name="veiculo"> atualize os dados do Veiculo</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Veiculo veiculo)
        {
            try
            {
                _veiculoRepository.Atualizar(id, veiculo);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
