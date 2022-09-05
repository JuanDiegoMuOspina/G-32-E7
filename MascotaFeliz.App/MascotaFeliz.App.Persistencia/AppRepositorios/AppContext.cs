using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Pesistencia
{
    public class App : DbContext    {

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Dueno> Dueno { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<Veterinario> Veterinario { get; set; }
        public DbSet<VisitaPyP> VisitaPyP { get; set; }

    }
}