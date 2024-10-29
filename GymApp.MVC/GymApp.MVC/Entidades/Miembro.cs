using System.ComponentModel.DataAnnotations;

namespace GymApp.MVC.Entidades
{
    public class Miembro : Persona
    {

        [EmailAddress(ErrorMessage = "Por favor, introduce un correo electrónico válido.")]
        public string Email { get; set; } = string.Empty;
        public Membresia? MembresiaActual { get; set; }
        public List<Clase> ClasesInscritas { get; set; } = new List<Clase>();

        public void Registrar()
        {
            // Aquí iría la lógica para registrar un nuevo miembro en la base de datos
        }

        public void RenovarMembresia(string tipoMembresia)
        {
            MembresiaActual = new Membresia
            {
                Tipo = tipoMembresia,
                
                FechaFin = tipoMembresia == "Mensual" ? DateTime.Now.AddMonths(1) :
                           tipoMembresia == "Trimestral" ? DateTime.Now.AddMonths(3) :
                           DateTime.Now.AddYears(1),
                MiembroId = this.Id,
                Miembro = this
            };
        }
    }
}
