﻿using System.ComponentModel.DataAnnotations;

namespace GymApp.MVC.Entidades
{
    public class Entrenador: Persona
    {
        [Required]
        public string Especialidad { get; set; } = string.Empty;
        public List<Clase> ClasesAsignadas { get; set; } = new List<Clase>();

        public void AsignarClase(Clase clase)
        {
            if (!ClasesAsignadas.Contains(clase))
            {
                ClasesAsignadas.Add(clase);
                clase.Entrenador = this;
                clase.EntrenadorId = this.Id;
            }
        }
    }
}

