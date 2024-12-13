using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;
public class Venta
{
    [Key]
    public int VentaId { get; set; }

    [Required(ErrorMessage = "El código del cliente es obligatorio.")]
    public int CodigoCliente { get; set; }

    [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
    public string NombreCliente { get; set; } = string.Empty;

    [Required(ErrorMessage = "El código del producto es obligatorio.")]
    public int CodigoProducto { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    public string NombreProducto { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe ingresar una cantidad.")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Debe seleccionar una forma de pago.")]
    public string FormaDePago { get; set; } = "Efectivo";

    public float? PrecioSublimacion { get; set; }

    public bool EnBlanco { get; set; } = false;
}