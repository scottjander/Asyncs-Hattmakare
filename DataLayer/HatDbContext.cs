using System;
using System.Data.Entity;
using System.Linq;
using DataLayer.Models;


namespace DataLayer
{
    public class HatDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Hat> Hats { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SpecialHat> SpecialHats { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<ShippingLabel> ShippingLabels { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceFromSupplier> InvoiceFromSuppliers { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // Your context has been configured to use a 'HatDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AsyncHattprojekt.HatDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HatDbContext' 
        // connection string in the application configuration file.
        public HatDbContext()
            : base("name=HatDbContext")
        {   

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; } 
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}