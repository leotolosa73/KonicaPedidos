
namespace KonicaPedidos.Application.Entities
{
    public class Pedido : BaseEntity
    {
        public string Descripcion { get; set; } = string.Empty;
        public Guid VehiculoId { get; set; }
        public string Ubicacion { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }

    }
}
