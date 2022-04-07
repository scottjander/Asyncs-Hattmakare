namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coolt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SpecialHats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Comment = c.String(),
                        AmountOfDecorations = c.Int(nullable: false),
                        ImagePath = c.String(),
                        Name = c.String(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            DropColumn("dbo.Hats", "AmountOfDecorations");
            DropColumn("dbo.Hats", "ImagePath");
            DropColumn("dbo.Hats", "Name");
            DropColumn("dbo.Hats", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hats", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Hats", "Name", c => c.String());
            AddColumn("dbo.Hats", "ImagePath", c => c.String());
            AddColumn("dbo.Hats", "AmountOfDecorations", c => c.Int());
            DropForeignKey("dbo.SpecialHats", "Order_Id", "dbo.Orders");
            DropIndex("dbo.SpecialHats", new[] { "Order_Id" });
            DropTable("dbo.SpecialHats");
        }
    }
}
