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
            var https = HttpContext.Request.IsHttps;
            var caminho = HttpContext.Request.Path;
            var status = HttpContext.Response.StatusCode;
            var conexao = HttpContext.Connection.ToString();

            return https + "\r\n" + caminho + "\r\n" + status +"\r\n" + conexao;
            //return "Esse é o método Action Padrão Alterado Novamente...";
        }

        public IActionResult Detalhe()
        {
            var pessoa  = new {ID = 1, Nome = "Edutecni"};
            return new ObjectResult(pessoa);
            
            //return File("images/banner1.svg", "image/svg+xml");
            //return Content("teste.pdf", "application/pdf");
            //return Content("Uma string simples");
            //return RedirectToAction("Index", "Home", new {pagina=1, ordem="nome"});
            //return View();
        }
    }
}
