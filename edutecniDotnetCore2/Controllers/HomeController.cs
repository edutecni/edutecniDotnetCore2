using edutecniDotnetCore2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace edutecniDotnetCore2.Controllers
{
    public class HomeController : Controller
    {
        // Rotas customizadas direto no controller é a Ideal se for necessário rotas Customizadas
        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("home/about")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // Também pode se utilizar os verbos HttpGet ou HttpPost para se customizar rotas conforme exemplo abaixo
        [HttpGet("home/contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
