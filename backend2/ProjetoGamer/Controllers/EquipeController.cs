using Microsoft.AspNetCore.Mvc;
using ProjetoGamer.Infra;
using ProjetoGamer.Models;

namespace ProjetoGamer.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        Context c = new Context(); // instancia do objeto que acess o bd
        

        [Route("Listar")]//http://localhost/Equipe/Listar

        public IActionResult Index()
        {
           ViewBag.Equipe = c.Equipe.ToList();
           //ViewBag e uma classe do framework para mostrar a lista na View 
            return View();
        }
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.Nome = form["Nome"].ToString();
            novaEquipe.Imagem = form["Imagem"].ToString();
            c.Equipe.Add(novaEquipe);
            c.SaveChanges();
            ViewBag.Equipe=c.Equipe.ToList();
            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}