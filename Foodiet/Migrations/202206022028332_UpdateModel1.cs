namespace Foodiet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meal", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Meal", "Name");
        }
    }
}
