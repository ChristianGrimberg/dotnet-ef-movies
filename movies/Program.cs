using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace movies
{
    public class Program
    {
        static void Main(string[] args)
        {
           if(args.Length == 0 || args == null)
           {
               Movie newMovie = new Movie();
               MoviesDbContext db = new MoviesDbContext();

               Console.Write("Enter the name of the movie: ");
               newMovie.Name = Console.ReadLine();

               Console.Write("Enter the year: ");
               newMovie.Year = int.Parse(Console.ReadLine());

               db.Add(newMovie);
               db.SaveChanges();
           }
           else
           {
               Console.WriteLine("This application does not accept parameters");
           }
        }
    }
}
