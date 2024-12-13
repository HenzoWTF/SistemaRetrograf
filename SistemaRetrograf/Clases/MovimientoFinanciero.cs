using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;
public class MovimientoFinanciero
{
    [Key]
    public int MovimientoId { get; set; }

    [Required(ErrorMessage = "Debe especificar el tipo de movimiento.")]
    public string TipoMovimiento { get; set; }

    [Required(ErrorMessage = "Debe ingresar un monto.")]
    public float Monto { get; set; }

    [Required(ErrorMessage = "Debe especificar una fecha.")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    public string Descripcion { get; set; } = string.Empty;

    public int? FacturaId { get; set; }
    public Factura? Factura { get; set; }

    public int? CompraId { get; set; }
    public Compra? Compra { get; set; }
}