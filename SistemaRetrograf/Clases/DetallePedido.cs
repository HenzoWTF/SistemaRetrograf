using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;

public class DetallePedido
{
    [Key]
    public int DetallePedidoId { get; set; }

    [Required(ErrorMessage = "Debe especificar el producto.")]
    public int ProductoId { get; set; }
    public Productos Productos { get; set; } // Relación con Producto

    [Required(ErrorMessage = "Debe ingresar una cantidad.")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Debe ingresar el precio unitario.")]
    public float PrecioUnitario { get; set; }

    public string Notas { get; set; } = string.Empty; // Notas adicionales para este detalle
}

