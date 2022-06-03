namespace Foodiet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Food", "Meal_MealID", "dbo.Meal");
            DropIndex("dbo.Food", new[] { "Meal_MealID" });
            CreateTable(
                "dbo.FoodMeal",
                c => new
                    {
                        FoodID = c.Int(nullable: false),
                        MealID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FoodID, t.MealID })
                .ForeignKey("dbo.Food", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Meal", t => t.MealID, cascadeDelete: true)
                .Index(t => t.FoodID)
                .Index(t => t.MealID);
            
            DropColumn("dbo.Food", "Meal_MealID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Food", "Meal_MealID", c => c.Int());
            DropForeignKey("dbo.FoodMeal", "MealID", "dbo.Meal");
            DropForeignKey("dbo.FoodMeal", "FoodID", "dbo.Food");
            DropIndex("dbo.FoodMeal", new[] { "MealID" });
            DropIndex("dbo.FoodMeal", new[] { "FoodID" });
            DropTable("dbo.FoodMeal");
            CreateIndex("dbo.Food", "Meal_MealID");
            AddForeignKey("dbo.Food", "Meal_MealID", "dbo.Meal", "MealID");
        }
    }
}
