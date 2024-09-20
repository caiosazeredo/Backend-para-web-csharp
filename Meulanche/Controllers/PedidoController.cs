using Meulanche.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Meulanche.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        // Armazenando múltiplos pedidos em uma lista
        private static List<Pedido> pedidos = new List<Pedido>();
        private static int proximoId = 1;

        // GET: api/pedido
        [HttpGet]
        public IActionResult GetPedidos()
        {
            if (pedidos.Count == 0)
            {
                return NotFound("Nenhum pedido foi feito.");
            }

            return Ok(pedidos);
        }

        // POST: api/pedido
        [HttpPost]
        public IActionResult AdicionarPedido([FromBody] Pedido novoPedido)
        {
            // Atribui um novo ID para cada pedido
            novoPedido.Id = proximoId++;
            pedidos.Add(novoPedido);

            return Ok(novoPedido);
        }
    }
}
