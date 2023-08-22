using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    public class ValuesController : ControllerBase
    {
    }
}
