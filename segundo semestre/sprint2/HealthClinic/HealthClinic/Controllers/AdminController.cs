using HealthClinic.Interfaces;
using HealthClinic.Repositories;
using HealthClinic.Domains;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        [Produces("application/json")]
        public class AdminController : ControllerBase
        {
            private readonly IAdminRepository _adminRepository;
       
            public AdminController()
            {
                _adminRepository = new AdminRepository();
            }
        /// <summary>
        /// Busca o usuarios do tipo ADMIN pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Busca o usuarios do tipo ADMIN pelo ID</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                return Ok(_adminRepository.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Listar todo usuarios do tipo ADMIN
        /// </summary>
        /// <returns>Listar todo usuarios do tipo ADMIN</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_adminRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Cadastra um usuario do tipo ADMIN
        /// </summary>
        /// <param name="admin"></param>
        /// <returns>Cadastra um usuario do tipo ADMIN</returns>
        [HttpPost]
        public IActionResult Post(Admin admin)
        {
            try
            {
                _adminRepository.Cadastrar(admin);

                return StatusCode(201, admin);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }


    }
}
