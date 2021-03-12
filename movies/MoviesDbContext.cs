using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace movies
{
    public class MoviesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            //optionsBuilder.UseSqlServer("Server=.;Database=Movies;UID=sa;PWD=_YourStrongPassword1234;");
            optionsBuilder.UseSqlServer(config["movies-db"]);
        }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }
    }
}