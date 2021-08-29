using System.Collections.Generic;
using edutecniDotnetCore2.Models;
using edutecniDotnetCore2.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace edutecniDotnetCore2.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]
    public class ClientesController : Controller
    {        
        public IActionResult Detalhe()
        {
            Cliente cliente = new Cliente()
            {
                ClienteId = 100,
                Nome = "Eduardo",
                Email = "edutecni@yahoo.com.br"
            };

            var pedidos = new List<Pedido>()
            {
                new Pedido {
                    PedidoId = 1,
                    Nome = "Pedido 1"
                },

                new Pedido {
                    PedidoId = 2,
                    Nome = "Pedido 2"
                }
            };

            var viewModel = new ClientePedidoViewModel()
            {
                Cliente = cliente,
                Pedidos = pedidos
            };

            return View(viewModel);
        }
    }
}