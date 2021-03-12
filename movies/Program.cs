using System;

namespace movies
{
    public class Program
    {
        static void Main(string[] args)
        {
           int records;
           var db = new MoviesDbContext();

           if(args.Length == 0 || args == null)
           {
               records = InsertNewMovie(db);

               if(records != 0)
               {
                   Console.WriteLine("{0} records were stored.", records);
               }
               else
               {
                   Console.WriteLine("Error storing the data in the database.");
               }
           }
           else
           {
               Console.WriteLine("This application does not accept parameters.");
           }
        }

        static int InsertNewMovie(MoviesDbContext db)
        {
            int result = 0;
            var newMovie = new Movie();

            Console.Write("Enter the name of the movie: ");
            newMovie.Name = Console.ReadLine();

            Console.Write("Enter the year: ");
            newMovie.Year = int.Parse(Console.ReadLine());

            db.Add(newMovie);
            result = db.SaveChanges();

            return result;
        }
    }
}
