namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newhat : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.HatStocks", newName: "Stocks");
            AddColumn("dbo.Hats", "size", c => c.Int(nullable: false));
            AddColumn("dbo.Hats", "color", c => c.String());
            AddColumn("dbo.Hats", "itemName", c => c.String());
            AddColumn("dbo.Hats", "stock_Id", c => c.Int());
            AddColumn("dbo.Stocks", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Hats", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Stocks", "HatSize", c => c.Int());
            AlterColumn("dbo.Orders", "TotalPrice", c => c.Double(nullable: false));
            CreateIndex("dbo.Hats", "stock_Id");
            AddForeignKey("dbo.Hats", "stock_Id", "dbo.Stocks", "Id");
            DropColumn("dbo.Stocks", "ItemName");
            DropColumn("dbo.Stocks", "Price");
            DropColumn("dbo.Stocks", "AmountInStock");
            DropColumn("dbo.Stocks", "Colour");
            DropTable("dbo.FabricStocks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FabricStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        Price = c.Double(nullable: false),
                        AmountInStock = c.Double(nullable: false),
                        Colour = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Stocks", "Colour", c => c.String());
            AddColumn("dbo.Stocks", "AmountInStock", c => c.Double(nullable: false));
            AddColumn("dbo.Stocks", "Price", c => c.Double(nullable: false));
            AddColumn("dbo.Stocks", "ItemName", c => c.String());
            DropForeignKey("dbo.Hats", "stock_Id", "dbo.Stocks");
            DropIndex("dbo.Hats", new[] { "stock_Id" });
            AlterColumn("dbo.Orders", "TotalPrice", c => c.Int(nullable: false));
            AlterColumn("dbo.Stocks", "HatSize", c => c.Int(nullable: false));
            AlterColumn("dbo.Hats", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Stocks", "Discriminator");
            DropColumn("dbo.Hats", "stock_Id");
            DropColumn("dbo.Hats", "itemName");
            DropColumn("dbo.Hats", "color");
            DropColumn("dbo.Hats", "size");
            RenameTable(name: "dbo.Stocks", newName: "HatStocks");
        }
    }
}
