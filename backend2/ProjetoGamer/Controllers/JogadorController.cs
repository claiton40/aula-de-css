
using Microsoft.AspNetCore.Mvc;

using ProjetoGamer.Infra;

namespace ProjetoGamer.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }
        Context j = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = j.Jogador.ToList();
            ViewBag.Equipe = j.Equipe.ToList();
            //ViewBag e uma classe do framework para mostrar a lista na View
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}