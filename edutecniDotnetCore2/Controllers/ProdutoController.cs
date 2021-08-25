using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edutecniDotnetCore2.Controllers
{
    public class ProdutoController : Controller
    {
        
        public IActionResult Index(int? pagina, string ordem)
        {
            if(!pagina.HasValue)
                pagina = 1;

            if(String.IsNullOrEmpty(ordem))
                ordem= "Nome";

            return Content(string.Format("Pagina: {0} Ordem: {1}", pagina, ordem));

            // var https = HttpContext.Request.IsHttps;
            // var caminho = HttpContext.Request.Path;
            // var status = HttpContext.Response.StatusCode;
            // var conexao = HttpContext.Connection.ToString();

            // return https + "\r\n" + caminho + "\r\n" + status +"\r\n" + conexao;
            //return "Esse é o método Action Padrão Alterado Novamente...";
        }

        public IActionResult Edit(int id)
        {
            return Content("Valor do Id: " + id);
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

        public IActionResult DataLancamento(int ano, int mes)
        {
            return Content("Ano: " + ano + " \r\nMes: " + mes);
        }

        // Outra maneira de passar parametros por rotas customizadas
        [Route("produto/lancamentos/{ano:int}/{mes:range(1,12)}/{dia:range(1,31)}")]
        public IActionResult DataLancamentoDia(int ano, int mes, int dia)
        {
            return Content("Ano: " + ano + " Mes: " + mes + " Dia: " + dia);
        }
    }
}
