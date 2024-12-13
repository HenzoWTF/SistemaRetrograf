using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;

public class Pedido
{
    [Key]
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "El cliente es obligatorio.")]
    public int ClienteId { get; set; }
    public Clientes Cliente { get; set; }

    [Required(ErrorMessage = "Debe indicar la fecha de creación.")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Debe especificar la fecha límite.")]
    public DateTime FechaEntrega { get; set; }

    public string Estado { get; set; }

    public ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
}
