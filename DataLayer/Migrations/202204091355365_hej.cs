namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hej : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Stocks", newName: "FabricStocks");
            DropForeignKey("dbo.Hats", "Stock_Id", "dbo.Stocks");
            DropIndex("dbo.Hats", new[] { "Stock_Id" });
            CreateTable(
                "dbo.HatStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HatSize = c.Int(nullable: false),
                        ItemName = c.String(),
                        Price = c.Double(nullable: false),
                        AmountInStock = c.Double(nullable: false),
                        Colour = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            AddColumn("dbo.FabricStocks", "ItemName", c => c.String());
            AddColumn("dbo.FabricStocks", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.FabricStocks", "AmountInStock", c => c.Double(nullable: false));
            AddColumn("dbo.FabricStocks", "Colour", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "Comment");
            DropColumn("dbo.Hats", "size");
            DropColumn("dbo.Hats", "color");
            DropColumn("dbo.Hats", "itemName");
            DropColumn("dbo.Hats", "AmountOfDecorations");
            DropColumn("dbo.Hats", "ImagePath");
            DropColumn("dbo.Hats", "Discriminator");
            DropColumn("dbo.Hats", "Stock_Id");
            DropColumn("dbo.FabricStocks", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FabricStocks", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Hats", "Stock_Id", c => c.Int());
            AddColumn("dbo.Hats", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Hats", "ImagePath", c => c.String());
            AddColumn("dbo.Hats", "AmountOfDecorations", c => c.Int());
            AddColumn("dbo.Hats", "itemName", c => c.String());
            AddColumn("dbo.Hats", "color", c => c.String());
            AddColumn("dbo.Hats", "size", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Comment", c => c.String());
            DropForeignKey("dbo.SpecialHats", "Order_Id", "dbo.Orders");
            DropIndex("dbo.SpecialHats", new[] { "Order_Id" });
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            DropColumn("dbo.FabricStocks", "Colour");
            DropColumn("dbo.FabricStocks", "AmountInStock");
            DropColumn("dbo.FabricStocks", "Price");
            DropColumn("dbo.FabricStocks", "ItemName");
            DropTable("dbo.SpecialHats");
            DropTable("dbo.HatStocks");
            CreateIndex("dbo.Hats", "Stock_Id");
            AddForeignKey("dbo.Hats", "Stock_Id", "dbo.Stocks", "Id");
            RenameTable(name: "dbo.FabricStocks", newName: "Stocks");
        }
    }
}
