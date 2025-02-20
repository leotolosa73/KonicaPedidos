
using KonicaPedidos.Application.Entities;

namespace KonicaPedidos.Application.Interfaces
{
    public interface IPedidoRepository : IGenericRepository<Pedido>
    {
        Task<IEnumerable<Pedido>> GetByVehiculoIdAsync(Guid vehiculoId);
    }
}
