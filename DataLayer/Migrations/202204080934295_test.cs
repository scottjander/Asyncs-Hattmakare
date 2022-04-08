namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
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
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        CustomerBonusPoints = c.Int(nullable: false),
                        Comment = c.String(),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
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
                        Price = c.Double(nullable: false),
                        Comment = c.String(),
                        size = c.Int(nullable: false),
                        color = c.String(),
                        itemName = c.String(),
                        AmountOfDecorations = c.Int(),
                        ImagePath = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Order_Id = c.Int(),
                        Stock_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .ForeignKey("dbo.Stocks", t => t.Stock_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Stock_Id);
            
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
                        TotalPrice = c.Double(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
            DropForeignKey("dbo.Hats", "Stock_Id", "dbo.Stocks");
            DropForeignKey("dbo.ShippingLabels", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Invoices", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Hats", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Invoices", "InvoiceAddress_Id", "dbo.Addresses");
            DropForeignKey("dbo.Customers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.ShippingLabels", new[] { "Address_Id" });
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.Invoices", new[] { "Order_Id" });
            DropIndex("dbo.Invoices", new[] { "InvoiceAddress_Id" });
            DropIndex("dbo.Hats", new[] { "Stock_Id" });
            DropIndex("dbo.Hats", new[] { "Order_Id" });
            DropIndex("dbo.Customers", new[] { "Address_Id" });
            DropTable("dbo.ShippingLabels");
            DropTable("dbo.Stocks");
            DropTable("dbo.Orders");
            DropTable("dbo.Invoices");
            DropTable("dbo.IncomingInvoices");
            DropTable("dbo.Hats");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
