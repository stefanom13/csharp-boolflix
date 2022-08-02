using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Database
{
    public class BoolflixContext : DbContext
    {

        public DbSet<ContenutoVideo> ContenutiVideo { get; set; }
        public DbSet<Film>? Films { get; set; }
        public DbSet<Serie>? Series { get; set; }
        public DbSet<Stagione>? Stagioni { get; set; }
        public DbSet<Episodio>? Episodi { get; set; }

        public DbSet<Genere> Generi { get; set; }

      //  public DbSet<CronologiaRiproduzione> CronologiaRiproduzioni { get; set; }

        public DbSet<PlayList> PlayLists { get; set; }

        public DbSet<Profilo> Profili { get; set; }
        

        public BoolflixContext()
         {
         }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BoolflixDb;Integrated Security=True");
        }
    }
}
