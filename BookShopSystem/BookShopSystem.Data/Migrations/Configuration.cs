namespace BookShopSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    //TO DO Make Class globally accessible
    public sealed class Configuration : DbMigrationsConfiguration<BookShopSystem.Data.BookShopContext>
    {
        private Random random = new Random();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "BookShopSystem.Data.BookShopContext";

        }

        protected override void Seed(BookShopSystem.Data.BookShopContext context)
        {
            context.Categoryes.AddOrUpdate(
                new Category() { CategoryId = 1, Name = "Fantasy" }
                );

            context.Authors.AddOrUpdate(
                new Author() { AuthorId = 1, FirstName = "Roger", LastName = "Porter" }
                );

            context.Books.AddOrUpdate(

                new Book() { BookId = 1, Edition = (Models.Type)1, ReleaseDate = DateTime.Parse("20/01/1998"), Copies = 27274, Price = 15.31 , AgeRestriction = (AgeRestriction)2, Title = "Absalom", AutorId = 1}
                );
        }
    }
}
