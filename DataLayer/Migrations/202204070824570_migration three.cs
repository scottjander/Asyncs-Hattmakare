namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationthree : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
        }
    }
}
