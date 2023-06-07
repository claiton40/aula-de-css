
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
            ViewBag.UserName = HttpContext.Session.GetString("UserNanme");
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
            novoJogador.Senha = form["Senha"].ToString();
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
            Jogador Jog = j.Jogador.First (Jog => Jog.IdJogador == id);;
            ViewBag.Jogador = Jog;
            ViewBag.Equipe = j.Equipe.ToList();
            return View("Edit");
        }

         [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Jogador Jog = new Jogador();
            
            Jog.IdJogador = int.Parse(form["IdJogador"].ToString());
            Jog.Nome = form["Nome"].ToString();
            Jog.Email = form["Email"].ToString();
            Jog.Senha = form["Senha"].ToString();
            Jog.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            Jogador Joga  = j.Jogador.First(j => j.IdJogador == Jog.IdJogador);

            Joga.Nome = Jog.Nome;
            Joga.Email = Jog.Email;
            Joga.Senha = Jog.Senha;
            Joga.IdEquipe = Jog.IdEquipe;

            j.Jogador.Update(Joga);
            j.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}