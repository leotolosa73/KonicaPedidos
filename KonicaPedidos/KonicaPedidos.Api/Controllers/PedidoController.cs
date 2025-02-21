using KonicaPedidos.Application.Entities;
using KonicaPedidos.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace KonicaPedidos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoService _pedidoService;

        // Inyección de dependencias del servicio
        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        // POST: api/Pedido
        [HttpPost]
        public async Task<IActionResult> CreatePedido(Pedido pedido)
        {
            var createdPedido = await _pedidoService.CreatePedidoAsync(pedido);
            return CreatedAtAction(nameof(GetPedidoById), new { id = createdPedido.Id }, createdPedido);
        }

        // GET: api/Pedido/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedidoById(Guid id)
        {
            // Suponiendo que tienes un método para obtener un pedido por ID
            var pedido = await _pedidoService.GetPedidosByVehiculoAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

    }
}

