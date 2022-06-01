namespace Foodiet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Calories = c.Single(nullable: false),
                        Carbohydrates = c.Single(nullable: false),
                        Proteins = c.Single(nullable: false),
                        Fats = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Food");
        }
    }
}
