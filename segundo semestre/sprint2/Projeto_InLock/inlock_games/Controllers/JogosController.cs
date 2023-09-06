using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using inlock_games.Domains;
using inlock_games.Interfaces;
using inlock_games.Repositories;


namespace inlock_games.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class JogosController : ControllerBase
    {
        
    }
}