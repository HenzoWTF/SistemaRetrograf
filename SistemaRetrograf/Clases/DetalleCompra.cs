using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;
public class DetalleCompra
{
    [Key]
    public int DetalleCompraMaterialId { get; set; }

    [Required(ErrorMessage = "El código del material es obligatorio.")]
    public int CodigoMaterial { get; set; }

    [Required(ErrorMessage = "El nombre del material es obligatorio.")]
    public string NombreMaterial { get; set; } = string.Empty;

    [Required(ErrorMessage = "Debe ingresar una cantidad.")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Debe ingresar un precio unitario.")]
    public float PrecioUnitario { get; set; }

    public float Total => Cantidad * PrecioUnitario;

    public int CompraId { get; set; }
    public Compra Compra { get; set; }
}
