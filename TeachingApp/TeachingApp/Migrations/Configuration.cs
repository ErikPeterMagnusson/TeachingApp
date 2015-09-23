namespace TeachingApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeachingApp.DataConnectionlayer.TeachingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeachingApp.DataConnectionlayer.TeachingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            // SEED FOR PICTURE
            context.Picture.AddOrUpdate(
                new Models.Picture { ID = 1, Name = "Horse", Word = "Horse" },
                new Models.Picture { ID = 2, Name = "Dog", Word = "Dog" },
                new Models.Picture { ID = 3, Name = "Cat", Word = "Cat" },
                new Models.Picture { ID = 4, Name = "Pig", Word = "Pig" },
                new Models.Picture { ID = 5, Name = "Bird", Word = "Bird" }
                );
            //      context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
