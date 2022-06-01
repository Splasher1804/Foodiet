namespace Foodiet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.ObjectModel;

    internal sealed class Configuration : DbMigrationsConfiguration<Foodiet.Models.FoodContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Foodiet.Models.FoodContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Food f1 = new Food() { Description = "bread", Calories = 500, Carbohydrates = 78, Fats = 4, Proteins = 12 };
            Food f2 = new Food() { Description = "apple", Calories = 5000, Carbohydrates = 722, Fats = 4, Proteins = 1 };

            context.Logins.AddOrUpdate(x => x.UserID,
            new Login() { UserID = 1, Username = "user", Password = "user" },
            new Login() { UserID = 2, Username = "admin", Password = "admin" }
            );

            context.Foods.AddOrUpdate(x => x.FoodID,
            f1,
            f2
            );

            context.Meals.AddOrUpdate(x => x.MealID,
            new Meal() { Description = "breakfast", Foods = new Collection<Food> { f1, f2 } },
            new Meal() { Description = "lunch", Foods = new Collection<Food> { f2 } }
            );
        }
    }
}
