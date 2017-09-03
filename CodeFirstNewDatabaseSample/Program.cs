using CodeFirstNewDatabaseSample.DAL;
using CodeFirstNewDatabaseSample.Models;
using System;
using System.Linq;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog() { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = db.Blogs.OrderBy(b => b.Name);

                Console.WriteLine("All blogs in the database:");
                foreach (var b in query)
                {
                    Console.WriteLine(b.Name);
                }


                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
