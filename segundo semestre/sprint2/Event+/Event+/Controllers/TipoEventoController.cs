using Event_.Domains;
using Event_.Interfaces;
using Event_.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Event_.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        [Produces("application/json")]
        public class TipoEventoController : ControllerBase
        {
            private ITipoEventoRepository _tipoEventoRepository { get; set; }

            public TipoEventoController()
            {
                _tipoEventoRepository = new TipoEventoRepository();
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_tipoEventoRepository.Listar());
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpGet("{id}")]
            public IActionResult GetById(Guid id)
            {
                try
                {
                    return Ok(_tipoEventoRepository.BuscarPorId(id));
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpPost]
            public IActionResult Post(TipoEvento tipoEvento)
            {
                try
                {
                    _tipoEventoRepository.Cadastrar(tipoEvento);

                    return StatusCode(201, tipoEvento);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpPut("{id}")]
            public IActionResult Put(Guid id, TipoEvento tipoEvento)
            {
                try
                {
                    _tipoEventoRepository.Atualizar(id, tipoEvento);

                    return NoContent();
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(Guid id)
            {
                try
                {
                    _tipoEventoRepository.Deletar(id);

                    return NoContent();
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
    }
