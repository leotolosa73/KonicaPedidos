
namespace KonicaPedidos.Application.Entities
{
    public class HistorialUbicacion : BaseEntity
    {
        public Guid VehiculoId { get; set; }
        public string Coordenadas { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
    }
}
