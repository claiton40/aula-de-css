using Microsoft.AspNetCore.Mvc;
using ProjetoGamer.Infra;
using ProjetoGamer.Models;

namespace ProjetoGamer.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        [TempData]
        public string Message { get; set; }

        Context c = new Context();
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [Route("Login")]
        public IActionResult Index()
        {
            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            string email = form["Email"].ToString();
            string senha = form["Senha"].ToString();

            Jogador JogadorBuscado = c.Jogador.FirstOrDefault(
                j => j.Email == email && j.Senha == senha
            );

            // Logica da sessao
            if (JogadorBuscado != null)
            {
                HttpContext.Session.SetString("UserName", JogadorBuscado.Nome);
                return LocalRedirect("~/");
            }

            Message = "Dados invalidos";

            return LocalRedirect("~/Login/Login");
        }

        [Route("LogOut")]
        public IActionResult LogOut() 
        {
            HttpContext.Session.Remove("UserName");
            return LocalRedirect("~/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
