
using KonicaPedidos.Application.Entities;

namespace KonicaPedidos.Application.Interfaces
{
    public interface IVehiculoRepository : IGenericRepository<Vehiculo>
    {
        Task<IEnumerable<Vehiculo>> GetByConductorAsync(string conductor);
    }
}
