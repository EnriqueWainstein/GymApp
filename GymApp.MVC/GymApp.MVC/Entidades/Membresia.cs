using System.ComponentModel.DataAnnotations;

namespace GymApp.MVC.Entidades
{
    public class Membresia
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public DateTime FechaInicio { get; } = DateTime.Now;
        public DateTime FechaFin { get; set; }
        public int MiembroId { get; set; }
        [Required]
        public Miembro Miembro { get; set; } = null!;
    
    public decimal CalcularCosto()
        {
            // Implementa la lógica real para calcular el costo basado en el tipo y duración
            switch (Tipo)
            {
                case "Mensual":
                    return 50.00m;
                case "Trimestral":
                    return 135.00m;
                case "Anual":
                    return 500.00m;
                default:
                    return 0;
            }
        }
    }
}
