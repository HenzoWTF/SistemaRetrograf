using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaRetrograf.Clases;

namespace SistemaRetrograf.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<CarritoDetalle> CarritoDetalle { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Cuadre> Cuadre { get; set; }
        public DbSet<DetalleCompra> DetalleCompra { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<MovimientoFinanciero> movimientoFinancieros { get; set; }
        public DbSet<Pedido> pedidos { get; set; }

    }
}
