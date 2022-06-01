using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Foodiet.Models
{
    public class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Login> Logins { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Meal>().HasMany(x => x.Foods).WithMany();
        //}

    }

    [Table("Food")]
    public class Food
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FoodID { get; set; }
        public string Description { get; set; }
        public float Calories { get; set; }

        public float Carbohydrates { get; set; }

        public float Proteins { get; set; }

        public float Fats { get; set; }


    }

   [Table("Meal")]
   public class Meal
   {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       [Key]
       public int MealID { get; set; }
       public string Description { get; set; }
       public virtual ICollection<Food> Foods { get; set; }
    }

   [Table("Login")]
   public class Login
   {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       [Key]
       public int UserID { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }
   }


}
