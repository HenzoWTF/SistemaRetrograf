using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;
public class Compra
{
    [Key]
    public int CompraId { get; set; }

    [Required(ErrorMessage = "El proveedor es obligatorio.")]
    public string Proveedor { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe ingresar un método de pago.")]
    public string MetodoDePago { get; set; } = "Efectivo";

    public DateTime FechaCompra { get; set; } = DateTime.Now;

    public List<DetalleCompra> DetallesCompra { get; set; } = new List<DetalleCompra>();
}
