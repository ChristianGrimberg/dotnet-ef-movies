using System;
using Microsoft.EntityFrameworkCore;

namespace movies
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            optionsBuilder.UseSqlServer(@"Provider=MSOLEDBSQL;Server=.;Database=Movies;UID=sa;PWD=YourStrongPassword1234;");
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
