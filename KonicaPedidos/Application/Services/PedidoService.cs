using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KonicaPedidos.Application.Entities;
using KonicaPedidos.Application.Interfaces;

namespace KonicaPedidos.Application.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        // Constructor: inyectamos las dependencias necesarias
        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        // Crear un nuevo pedido
        public async Task<Pedido> CreatePedidoAsync(Pedido pedido)
        {
            // Aquí podrías añadir lógica de validación, verificación de negocio, etc.
            var createdPedido = await _pedidoRepository.AddAsync(pedido);
            return createdPedido;
        }

        // Obtener todos los pedidos para un vehículo específico
        public async Task<IEnumerable<Pedido>> GetPedidosByVehiculoAsync(Guid vehiculoId)
        {
            var pedidos = await _pedidoRepository.GetByVehiculoIdAsync(vehiculoId);
            return pedidos;
        }

        // Actualizar un pedido
        public async Task<Pedido> UpdatePedidoAsync(Pedido pedido)
        {
            var updatedPedido = await _pedidoRepository.UpdateAsync(pedido);
            return updatedPedido;
        }

        // Eliminar un pedido
        public async Task DeletePedidoAsync(Guid id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }

    }
}
