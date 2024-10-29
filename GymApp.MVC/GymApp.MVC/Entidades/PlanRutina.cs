namespace GymApp.MVC.Entidades
{
    public class PlanRutina
    {
        public int Id { get; set; }
        public int MiembroId { get; set; }
        public Miembro Miembro { get; set; } = null!;
        public int EntrenadorId { get; set; }
        public Entrenador Entrenador { get; set; }= null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public String ejercicios { get; set; } = null!;

    }
}

