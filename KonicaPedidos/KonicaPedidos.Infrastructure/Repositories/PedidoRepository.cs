
using KonicaPedidos.Application.Entities;
using KonicaPedidos.Application.Interfaces;
using KonicaPedidos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KonicaPedidos.Application.Services
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Pedido>> GetByVehiculoIdAsync(Guid vehiculoId)
        {
            return await _dbSet.Where(p => p.VehiculoId == vehiculoId).ToListAsync();
        }
    }
}
