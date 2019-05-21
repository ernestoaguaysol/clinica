namespace WebAppVet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppVet.Data.ClinicaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppVet.Data.ClinicaDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Restaurants.AddOrUpdate(r => r.Name,
            //    new Restaurant { Name = "Sebatino's", City = "Baltimore", Country = "USA" },
            //    new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
            //    new Restaurant
            //    {
            //        Name = "Smaka",
            //        City = "Gothenburg",
            //        Country = "Sweden",
            //        Reviews = new List<RestaurantReview>
            //        {
            //           new RestaurantReview { Rating=5, Body="great Food!", ReviewerName="Scott" }
            //        }
            //    });
        }
    }
}
