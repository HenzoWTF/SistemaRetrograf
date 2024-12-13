using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;


public class Productos
{
    [Key]
    public int ProductoId { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public string Descripcion { get; set; } = string.Empty;

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime FechaCreacion { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Debe elegir una categoria.")]
    [Range(1, 100000, ErrorMessage = "El campo {0} debe ser mayor que 0 y menor que 100000.")]
    public float Precio1 { get; set; }

    [Required(ErrorMessage = "Debe especificar el precio especial.")]
    [Range(0, 100000, ErrorMessage = "El campo {0} debe ser mayor o igual a 0 y menor que 100000.")]
    public float Precio2 { get; set; }

    [Required(ErrorMessage = "Debe especificar el precio especial.")]
    [Range(0, 100000, ErrorMessage = "El campo {0} debe ser mayor o igual a 0 y menor que 100000.")]
    public float PrecioEspecial { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio.")]
    [Range(1, 100000, ErrorMessage = "El campo {0} debe ser mayor que 0 y menor que 100000.")]
    public int Cantidad { get; set; }
}
