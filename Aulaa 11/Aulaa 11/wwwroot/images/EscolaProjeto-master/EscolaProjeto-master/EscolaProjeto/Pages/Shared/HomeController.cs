using Microsoft.AspNetCore.Mvc;
using EscolaProjeto.Models;

namespace EscolaProjeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Diferenciais()
        {
            return View();
        }

        public IActionResult Localizacao()
        {
            return View();
        }
    }
}