namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        StreetNumber = c.String(),
                        TownName = c.String(),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                        CustomerBonusPoints = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Comment = c.String(),
                        AmountOfDecorations = c.Int(),
                        ImagePath = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
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
                "dbo.IncomingInvoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SumToPay = c.Double(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SumToPay = c.Double(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                        InvoiceAddress_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.InvoiceAddress_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.InvoiceAddress_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        DateFinished = c.DateTime(nullable: false),
                        Comment = c.String(),
                        TotalPrice = c.Int(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
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
            
            CreateTable(
                "dbo.ShippingLabels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Weight = c.Double(nullable: false),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShippingLabels", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Invoices", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Hats", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Invoices", "InvoiceAddress_Id", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "Id", "dbo.Addresses");
            DropIndex("dbo.ShippingLabels", new[] { "Address_Id" });
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.Invoices", new[] { "Order_Id" });
            DropIndex("dbo.Invoices", new[] { "InvoiceAddress_Id" });
            DropIndex("dbo.Hats", new[] { "Order_Id" });
            DropIndex("dbo.Customers", new[] { "Id" });
            DropTable("dbo.ShippingLabels");
            DropTable("dbo.FabricStocks");
            DropTable("dbo.Orders");
            DropTable("dbo.Invoices");
            DropTable("dbo.IncomingInvoices");
            DropTable("dbo.HatStocks");
            DropTable("dbo.Hats");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
