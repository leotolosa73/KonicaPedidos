
namespace KonicaPedidos.Application.Entities
{
    public class Vehiculo : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string Conductor { get; set; } = string.Empty;
        public List<HistorialUbicacion> HistorialUbicacion { get; set; } = new List<HistorialUbicacion>();
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
