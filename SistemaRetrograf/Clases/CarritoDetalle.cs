using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;
public class CarritoDetalle
{
    [Key]
    public int CarritoDetalleId { get; set; }

    public int CarritoId { get; set; }

    [ForeignKey("Productos")]
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Impuesto { get; set; }

    public decimal SubTotal { get; set; }
    public decimal Total { get; set; }

    public Boolean Pagado { get; set; }
}
