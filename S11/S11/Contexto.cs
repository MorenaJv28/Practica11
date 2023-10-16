using Microsoft.EntityFrameworkCore;

namespace Registro.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AWITA28;Database=Programacion2;Trusted_Connection=SSPI;MultipleActiveResultSets=true;TrustServerCertificate=true;");
        }
    }
}
