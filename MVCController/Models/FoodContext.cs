using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;



namespace MVCController.Models
{
    public class FoodContext : IdentityDbContext
    {
        public FoodContext() : base()
        {
        }
        public FoodContext(DbContextOptions<FoodContext> options)   : base(options) { }

        public System.Data.Entity.DbSet<Account> Account { get; set; }
        public System.Data.Entity.DbSet<Users> Users { get; set; }
        public System.Data.Entity.DbSet<Meal> Meal { get; set; }
        public System.Data.Entity.DbSet<Food> Food { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
