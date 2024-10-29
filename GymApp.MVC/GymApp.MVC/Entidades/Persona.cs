using System.ComponentModel.DataAnnotations;

namespace GymApp.MVC.Entidades
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [MaxLength (30)]
        public string Nombre { get; set; } = string.Empty;
    }
}
