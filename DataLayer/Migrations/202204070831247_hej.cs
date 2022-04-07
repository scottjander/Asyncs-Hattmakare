namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hej : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hats", "Name", c => c.String());
            AlterColumn("dbo.Hats", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Orders", "TotalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "TotalPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Hats", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Hats", "Name");
        }
    }
}
