using System.ComponentModel.DataAnnotations;

namespace SistemaRetrograf.Clases;

public class Cuadre
{
    [Key]
    public int CuadreId { get; set; }
    public float TotalIngresos { get; set; }
    public float TotalEgresos { get; set; }
    public float Balance { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
}
