namespace LightweightMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class make_year_mileage_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Year", c => c.Int());
            AlterColumn("dbo.Cars", "Mileage", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Mileage", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "Year", c => c.Int(nullable: false));
        }
    }
}
