using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foodiet.Models
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            using (var db = new FoodContext())
            {
                db.Foods.Add(new Food { Description = "Bread", Calories = 500, Carbohydrates = 78, Fats = 4, Proteins = 12 });
                db.SaveChanges();

                foreach (var food in db.Foods)
                {
                    Console.WriteLine(food.Description);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
