namespace BookShopSystem.Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;    //TO DO Make Class globally accessible
    public sealed class Configuration : DbMigrationsConfiguration<BookShopSystem.Data.BookShopContext>
    {
        Random random = new Random();
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "BookShopSystem.Data.BookShopContext";
        }

        protected override void Seed(BookShopSystem.Data.BookShopContext context)
        {
            ////for Seed uncoment

            //using (var reader = new StreamReader("categories.txt"))
            //{
            //    var line = reader.ReadLine();
            //    while (line != null)
            //    {
            //        var data = line.Split(new[] { ' ' }, 1);
            //        var name = data[0];

            //        context.Categoryes.Add(
            //    new Category()
            //    {
            //        Name = name,
            //    });
            //        line = reader.ReadLine();
            //    }
            //}

            //using (var reader = new StreamReader("authors.txt"))
            //{
            //    var line = reader.ReadLine();
            //    line = reader.ReadLine();
            //    while (line != null)
            //    {
            //        var data = line.Split(new[] { ' ' }, 2);
            //        var firstName = data[0];
            //        var lastName = data[1];

            //        context.Authors.Add(
            //    new Author()
            //    {
            //        FirstName = firstName,
            //        LastName = lastName
            //    });
            //        line = reader.ReadLine();
            //    }
            //}

            //using (var reader = new StreamReader("books.txt"))
            //{
            //    var line = reader.ReadLine();
            //    line = reader.ReadLine();
            //    while (line != null)
            //    {
            //        var data = line.Split(new[] { ' ' }, 6);
            //        var authorIndex = random.Next(0, 1000);
            //        var edition = (Models.Type)int.Parse(data[0]);
            //        var releaseDate = DateTime.ParseExact(data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
            //        var copies = int.Parse(data[2]);
            //        var price = double.Parse(data[3]);
            //        var ageRestriction = (AgeRestriction)int.Parse(data[4]);
            //        var title = data[5];

            //        context.Books.Add(

            //    new Book()
            //    {
            //        //BookId = 1,
            //        Edition = edition,
            //        ReleaseDate = releaseDate,
            //        Copies = copies,
            //        Price = price,
            //        AgeRestriction = ageRestriction,
            //        Title = title,
            //        AuthorId = 1
            //    });
            //        line = reader.ReadLine();
            //    }
            //}
        }
    }
}


