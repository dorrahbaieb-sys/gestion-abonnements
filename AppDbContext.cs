using Microsoft.EntityFrameworkCore;
using gestion_abonnements.Models;

namespace gestion_abonnements
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Abonnement> Abonnements { get; set; }
        public DbSet<Paiement> Paiements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\abonnements.db"));
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}