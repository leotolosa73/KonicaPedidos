
using KonicaPedidos.Application.Entities;
using KonicaPedidos.Application.Interfaces;
using KonicaPedidos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KonicaPedidos.Application.Services
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(ApplicationDbContext context) : base(context) { }

        public async Task<IEnumerable<Vehiculo>> GetByConductorAsync(string conductor)
        {
            return await _dbSet.Where(v => v.Conductor == conductor).ToListAsync();
        }
    }
}
