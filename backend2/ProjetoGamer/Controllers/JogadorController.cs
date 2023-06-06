
using Microsoft.AspNetCore.Mvc;

using ProjetoGamer.Infra;
using ProjetoGamer.Models;

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

        [Route("Cadastrar")]

        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            j.Jogador.Add(novoJogador);
            j.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");
        }

            [Route("Excluir/(id)")]
        public IActionResult Excluir(int id)
        {
            Jogador jog = j.Jogador.First (jog => jog.IdJogador == id);
             j.Jogador.Remove(jog);
            j.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/(id)")]
        public IActionResult Editar(int id)
        {
            Jogador jog = j.Jogador.First (jog => jog.IdJogador == id);;
            ViewBag.Jogador = jog;
            return View("Edit");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}