using System.Diagnostics;
using Academico_Dependencia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico_Dependencia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Contact() 
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            ViewData["Message"] = "Seja Bem-vindo as definições de política de privacidade de nossa instituição!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
