using System;
using Microsoft.AspNetCore.Mvc;
using edutecniDotnetCore2;

namespace edutecniDotnetCore2.Controllers
{
    public class TesteController : Controller
    {
        // [Route("teste")]
        // [Route("teste/index")]
        [Route("[controller]")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            // A passagem de dados por ViewBag e ViewData é feito de maneira
            // fracamente tipada. Deve ser utilizada para passar pequenas porções
            // de dados.
            // A ViewBag é um invólucro entorno da ViewData, que fornece uma 
            // informação dinâmica sobre a coleção.
            ViewData["Saudacao"] = "Olá...";
            ViewData["DataInicio"] = new DateTime(2021, 08, 28);
            ViewData["Endereco"] = new Endereco()
            {
                Nome = "Edutecni",
                Rua = "Rua Daniel de Toledo, 63",
                Cidade = "São Paulo",
                Estado = "SP"
            };

            // Tanto ViewBag quanto ViewData são passadas do mesmo jeito do controller
            // para a View. O que muda é na hora de recuperar na View onde se 
            // utiliza o ViewBag exemplo @ViewBag.EnderecoViewBag.Nome na View
            ViewData["EnderecoViewBag"] = new Endereco()
            {
                Nome = "Edutecni via ViewBag",
                Rua = "Rua Daniel de Toledo, 63",
                Cidade = "São Paulo",
                Estado = "SP"
            };

            ViewData["HoraAtual"] = DateTime.Now;
            ViewData["Caminhho"] = HttpContext.Request.Path;

            return View();
        }
    }
}