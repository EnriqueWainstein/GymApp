using Microsoft.EntityFrameworkCore;
using GymApp.MVC.Entidades;

namespace GymApp.MVC.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }
        public DbSet<PlanRutina> Planes { get; set; }
        public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clase>()
                .HasMany(c => c.MiembrosInscritos)
                .WithMany(m => m.ClasesInscritas)
                .UsingEntity(j => j.ToTable("ClaseMiembro"));

            modelBuilder.Entity<Clase>()
                .HasOne(c => c.Entrenador)
                .WithMany(e => e.ClasesAsignadas)
                .HasForeignKey(c => c.EntrenadorId);

            modelBuilder.Entity<Membresia>()
                .HasOne(m => m.Miembro)
                .WithOne(mb => mb.MembresiaActual)
                .HasForeignKey<Membresia>(m => m.MiembroId);

            modelBuilder.Entity<PlanRutina>()
                .HasOne(pr => pr.Miembro)
                .WithMany()
                .HasForeignKey(pr => pr.MiembroId);

            modelBuilder.Entity<PlanRutina>()
                .HasOne(pr => pr.Entrenador)
                .WithMany()
                .HasForeignKey(pr => pr.EntrenadorId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EGFV38O\\SQLEXPRESS;" +
                                            "Initial Catalog=GymDB;" +
                                            "TrustServerCertificate=true;" +
                                            "Encrypt=true;" +
                                            "Integrated Security=true;");
            }
        }
    }
}