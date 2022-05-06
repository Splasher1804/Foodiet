using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Foodiet.Data_Acces_Layer
{
    public class FoodContext : DbContext
    { 
        public FoodContext() : base("FoodContext")
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<Food> Food { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
