using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;

public class Factura
{
    [Key]
    public int FacturaId { get; set; }

    [Required(ErrorMessage = "El código del cliente es obligatorio.")]
    public int CodigoCliente { get; set; }

    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    public string NombreCliente { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;

    public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();

    [Required]
    public float Total { get; set; }

    public float Pagado { get; set; }

    public float Deuda => Total - Pagado;
}