namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
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
                        Phone = c.String(),
                        Email = c.String(),
                        CustomerBonusPoints = c.Int(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Id)
                .Index(t => t.Id);
            
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
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id);
            
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
                        order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.order_Id)
                .Index(t => t.order_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fabrics",
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
                "dbo.InvoiceFromSuppliers",
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
                        DateCreated = c.DateTime(nullable: false),
                        InvoiceAddress_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.InvoiceAddress_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.InvoiceAddress_Id)
                .Index(t => t.Order_Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpecialHats", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.ShippingLabels", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Invoices", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Invoices", "InvoiceAddress_Id", "dbo.Addresses");
            DropForeignKey("dbo.Hats", "order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Id", "dbo.Addresses");
            DropIndex("dbo.SpecialHats", new[] { "Order_Id" });
            DropIndex("dbo.ShippingLabels", new[] { "Address_Id" });
            DropIndex("dbo.Invoices", new[] { "Order_Id" });
            DropIndex("dbo.Invoices", new[] { "InvoiceAddress_Id" });
            DropIndex("dbo.Hats", new[] { "order_Id" });
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.Customers", new[] { "Id" });
            DropTable("dbo.SpecialHats");
            DropTable("dbo.ShippingLabels");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceFromSuppliers");
            DropTable("dbo.Fabrics");
            DropTable("dbo.Employees");
            DropTable("dbo.Hats");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
