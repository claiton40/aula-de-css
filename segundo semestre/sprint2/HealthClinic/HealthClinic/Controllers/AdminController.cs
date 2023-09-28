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



    }
}
