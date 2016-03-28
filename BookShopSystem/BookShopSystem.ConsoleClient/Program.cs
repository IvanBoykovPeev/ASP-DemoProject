using BookShopSystem.Data;
using BookShopSystem.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        }
    }
}
