namespace FoodPicker.Migrations.FoodMigrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodPicker.DAL.FoodContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\FoodMigrations";
        }

        protected override void Seed(FoodPicker.DAL.FoodContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    FirstName = "Julia",
                    LastName = "Khalack",
                    Email = "julia@foodpicker.com"
                },
                 new User
                {
                    FirstName = "Jordan",
                    LastName = "Young",
                    Email = "jordan@foodpicker.com"
                }
            };

            var restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Name = "Ice Cream Heaven",
                    Description = "Best ice cream in town",
                    StreetAddress = "4 Flanders Court",
                    City = "Moncton",
                    PostalCode = "E1C2P8",
                    Country = "Canada",
                    Province = "NB",
                    Phone ="(506) 555-5555",
                    UserID = 2
                }
            };

            var categories = new List<Category>
            {
                new Category
                {
                    CategoryName = "Ice cream"
                },
                new Category
                {
                    CategoryName = "Gelato"
                }
            };

            var foods = new List<Food>
            {
                new Food
                {
                    Name = "Vanilla",
                    Description = "The base of all ice creams",
                    RestaurantID = 1,
                    Price = 2.99M
                },
                new Food
                {
                    Name = "Chocolate",
                    Description = "Favorite food of chocolate lovers",
                    RestaurantID = 1,
                    Price = 3.49M
                }
            };


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