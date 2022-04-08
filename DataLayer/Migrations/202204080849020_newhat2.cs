namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newhat2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Stocks", "HatSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stocks", "HatSize", c => c.Int());
        }
    }
}
