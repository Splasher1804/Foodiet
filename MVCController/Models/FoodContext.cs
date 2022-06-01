using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MVCController.Models
{
    public class FoodContext : IdentityDbContext
    {
        public FoodContext() : base()
        {
        }
        public FoodContext(DbContextOptions<FoodContext> options)   : base(options) { }

        public DbSet<Account>   Account { get; set; }
        public DbSet<Users>     Users { get; set; }
        public DbSet<Meal>      Meal { get; set; }
        public DbSet<Food>      Food { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
