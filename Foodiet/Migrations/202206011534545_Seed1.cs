namespace Foodiet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.Meal",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.MealID);
            
            AddColumn("dbo.Food", "Meal_MealID", c => c.Int());
            CreateIndex("dbo.Food", "Meal_MealID");
            AddForeignKey("dbo.Food", "Meal_MealID", "dbo.Meal", "MealID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Food", "Meal_MealID", "dbo.Meal");
            DropIndex("dbo.Food", new[] { "Meal_MealID" });
            DropColumn("dbo.Food", "Meal_MealID");
            DropTable("dbo.Meal");
            DropTable("dbo.Login");
        }
    }
}
