using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edutecniDotnetCore2.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            return "Esse é o método Action Padrão...";
        }

        public IActionResult Detalhe()
        {
            return View();
        }
    }
}
