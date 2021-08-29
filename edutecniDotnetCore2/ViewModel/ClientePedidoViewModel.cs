using System.Collections.Generic;
using edutecniDotnetCore2.Models;

namespace edutecniDotnetCore2.ViewModel
{
    public class ClientePedidoViewModel
    {
        public Cliente Cliente { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}