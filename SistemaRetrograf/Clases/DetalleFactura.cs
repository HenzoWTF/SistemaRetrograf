using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;

public class DetalleFactura
{
    [Key]
    public int DetalleId { get; set; }

    [Required]
    public int CodigoProducto { get; set; }

    [Required]
    public string NombreProducto { get; set; } = string.Empty;

    [Required]
    public int Cantidad { get; set; }

    [Required]
    public float PrecioUnitario { get; set; }

    public float? PrecioSublimacion { get; set; } // Precio adicional, si aplica

    public float Subtotal => (PrecioSublimacion.HasValue ? PrecioSublimacion.Value : PrecioUnitario) * Cantidad;
}

