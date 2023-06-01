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
            // essa linha vai como string e queremos imagem.
            // novaEquipe.Imagem = form["Imagem"].ToString();
            if (form.Files.Count > 0)
            {
                var file = form.Files(0);
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                novaEquipe.Imagem = file.FileNme;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            c.Equipe.Add(novaEquipe);
            c.SaveChanges();
            return LocalRedirect("~/Equipe/Listar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("Cadastrar")]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}