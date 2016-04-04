namespace MusicStoreDemo.Migrations
{
    using System.Data.Entity.Migrations;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<MusicStoreDemo.Models.MusicStoreDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MusicStoreDemo.Models.MusicStoreDB";
        }

        protected override void Seed(Models.MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist{ Name = "Rush" },
                Genre = new Genre { Name = "Rock"},
                Price = 9.99m,
                Title = "Caravan"
            });
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
