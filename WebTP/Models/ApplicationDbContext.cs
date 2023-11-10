using Microsoft.EntityFrameworkCore;

namespace WebTP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Livre> Livres { get; set; }
        public DbSet<Abonne> Abonnes { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }
    }
}
