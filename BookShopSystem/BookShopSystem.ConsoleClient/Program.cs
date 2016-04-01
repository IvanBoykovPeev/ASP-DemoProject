using BookShopSystem.Data;
using BookShopSystem.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSystem.ConsoleClient
{
    class Program
    {
        static void Main()
        {
            var migrationStrategy = new MigrateDatabaseToLatestVersion<BookShopContext, Configuration>();
            Database.SetInitializer(migrationStrategy);
            var context = new Data.BookShopContext();
            //Initialize database
            var bookCount = context.Books.Count();
            DateTime date = new DateTime(2000, 01, 01);
            var all2000 = context.Books
                .Where(x => x.ReleaseDate > date)
                .Select(x => x.Title).ToList();
            Console.WriteLine(bookCount);
            foreach (var item in all2000)
            {
                Console.WriteLine(item);
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
