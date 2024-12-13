using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;
public class Carrito
{
    [Key]
    public int CarritoId { get; set; }

    [ForeignKey("Usuarios")]
    public int UsuarioId { get; set; }

    [Required]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    [ForeignKey("CarritoId")]
    public ICollection<CarritoDetalle> CarritoDetalle { get; set; } = new List<CarritoDetalle>();
}

