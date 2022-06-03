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
            Food f1 = new Food() { Description = "Bread", Calories = 270, Carbohydrates = 48, Fats = 4, Proteins = 10 };
            Food f2 = new Food() { Description = "Apple", Calories = 65, Carbohydrates = 18, Fats = 0.2f, Proteins = 0.3f };
            Food f3 = new Food() { Description = "Banana", Calories = 89, Carbohydrates = 23, Fats = 0.3f, Proteins = 1.1f };
            Food f4 = new Food() { Description = "Chicken Breast", Calories = 263, Carbohydrates = 15, Fats = 16, Proteins = 15 };
            Food f5 = new Food() { Description = "Beef", Calories = 410, Carbohydrates = 11, Fats = 26, Proteins = 33 };
            Food f6 = new Food() { Description = "Bacon", Calories = 470, Carbohydrates = 14, Fats = 29, Proteins = 38 };
            Food f7 = new Food() { Description = "Cheese", Calories = 357, Carbohydrates = 1.4f, Fats = 29, Proteins = 25 };
            Food f8 = new Food() { Description = "Pizza", Calories = 630, Carbohydrates = 41, Fats = 16, Proteins = 18 };
            Food f9 = new Food() { Description = "Pie", Calories = 560, Carbohydrates = 51, Fats = 14, Proteins = 9 };
            Food f10 = new Food() { Description = "Yoghurt", Calories = 373, Carbohydrates = 12, Fats = 10, Proteins = 18 };
            Food f11 = new Food() { Description = "Cereals", Calories = 324, Carbohydrates = 21, Fats = 4, Proteins = 12 };

            context.Logins.AddOrUpdate(x => x.UserID,
            new Login() { UserID = 1, Username = "user", Password = "user" },
            new Login() { UserID = 2, Username = "admin", Password = "admin" }
            );

            context.Foods.AddOrUpdate(x => x.FoodID,
            f1,
            f2
            );

            context.Meals.AddOrUpdate(x => x.MealID,
            new Meal() { Name="Breakfast", Description = "made for low calories", Foods = new Collection<Food> { f1, f2 } },
            new Meal() { Name="Lunch", Description = "Am hungry", Foods = new Collection<Food> { f2 } }
            );
        }
    }
}
