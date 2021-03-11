using System;

namespace movies
{
    public class Program
    {
        static void Main(string[] args)
        {
           if(args.Length == 0 || args == null)
           {
               int result;
               var newMovie = new Movie();
               var db = new MoviesDbContext();

               Console.Write("Enter the name of the movie: ");
               newMovie.Name = Console.ReadLine();

               Console.Write("Enter the year: ");
               newMovie.Year = int.Parse(Console.ReadLine());

               db.Add(newMovie);
               result = db.SaveChanges();

               if(result != 0)
               {
                   Console.WriteLine("{0} records were stored.", result);
               }
               else
               {
                   Console.WriteLine("Error storing the data in the database.");
               }
           }
           else
           {
               Console.WriteLine("This application does not accept parameters");
           }
        }
    }
}
