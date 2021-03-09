using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace movies
{
    public class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            Console.WriteLine($" Hello { config["name"] }!");
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public class MoviesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            //optionsBuilder.UseSqlServer("Server=.;Database=Movies;UID=sa;PWD=YourStrongPassword1234;");
            optionsBuilder.UseSqlServer(config["movies-db"]);
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
