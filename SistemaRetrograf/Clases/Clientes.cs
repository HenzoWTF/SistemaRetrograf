using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;

public class Clientes
{
    [Key]
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "El código del cliente es obligatorio.")]
    public string Codigo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La dirección es obligatoria.")]
    public string Direccion { get; set; } = string.Empty;

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    public string Ciudad { get; set; } = string.Empty;

    [Required(ErrorMessage = "El país es obligatorio.")]
    public string Pais { get; set; } = string.Empty;

    [Required(ErrorMessage = "El contacto es obligatorio.")]
    [Phone(ErrorMessage = "El formato del número de contacto no es válido.")]
    public string Contacto { get; set; } = string.Empty;

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [Phone(ErrorMessage = "El formato del número de teléfono no es válido.")]
    public string Telefono { get; set; } = string.Empty;

    public string? Nota { get; set; }

    public bool AplicaDescuento { get; set; } = false;

}