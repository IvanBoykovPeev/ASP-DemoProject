namespace BookShopSystem.Data
{
    using System.Data.Entity;
    using BookShopSystem.Models;

    public class BookShopContext : DbContext
    {
        public BookShopContext()
            : base("name=BookShopContext")
        {
        }
        public IDbSet<Book> Books { get; set; }
        public IDbSet<Category> Categoryes { get; set; }
        public IDbSet<Author> Authors { get; set; }
    }

}