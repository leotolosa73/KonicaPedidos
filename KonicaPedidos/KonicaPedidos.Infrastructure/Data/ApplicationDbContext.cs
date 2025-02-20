
using KonicaPedidos.Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace KonicaPedidos.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // DbSets para las entidades
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<HistorialUbicacion> HistorialUbicaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración adicional si es necesaria
        }
    }
}
