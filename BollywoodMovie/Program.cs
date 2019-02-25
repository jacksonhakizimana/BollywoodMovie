using System;

namespace BollywoodMovieApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BollywoodMovieContext())
            {
                Console.WriteLine("enter a title");
                string title = Console.ReadLine();
                Console.WriteLine("enter a category");
                string category = Console.ReadLine();
                Console.WriteLine("enter a year");
                string year = Console.ReadLine();

                db.BollywoodMovies.Add(new BollywoodMovietbl { title = title });
                db.BollywoodMovies.Add(new BollywoodMovietbl { year = year  });
                db.BollywoodMovies.Add(new BollywoodMovietbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var BollywoodMovietbl in db.BollywoodMovies)
                {
                    Console.WriteLine("{0}{1}{2}", BollywoodMovietbl.title, BollywoodMovietbl.year, BollywoodMovietbl.category_name);
                }
            }
        }
    }
}
