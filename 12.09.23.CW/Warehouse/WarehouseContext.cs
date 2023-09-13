using _12._09._23.CW.Warehouse.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace _12._09._23.CW.Warehouse
{
    public class WarehouseContext : DbContext
    {
        public DbSet<Models.Type> Types { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ToString());
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Models.Type type1 = new Models.Type() { ID = 1, Name = "Type 1" };
            Models.Type type2 = new Models.Type() { ID = 2, Name = "Type 2" };

            modelBuilder.Entity<Models.Type>().HasData(
                type1, 
                type2
                );

            Manufacturer manufacturer1 = new Manufacturer() { ID = 1, Name = "Manufacturer 1" };
            Manufacturer manufacturer2 = new Manufacturer() { ID = 2, Name = "Manufacturer 2" };

            modelBuilder.Entity<Manufacturer>().HasData(
                manufacturer1,
                manufacturer2
                );

            Product product1 = new Product()
            {
                ID = 1,
                Name = "Product 1",
                TypeID = type2.ID,
                ManufacturerID = manufacturer1.ID,
                Number = 75,
                CostPrice = 18,
                Date = DateTime.Now
            };

            Product product2 = new Product()
            {
                ID = 2,
                Name = "Product 2",
                TypeID = type1.ID,
                ManufacturerID = manufacturer2.ID,
                Number = 140,
                CostPrice = 80,
                Date = DateTime.Now
            };

            Product product3 = new Product()
            {
                ID = 3,
                Name = "New Product 3",
                TypeID = type2.ID,
                ManufacturerID = manufacturer2.ID,
                Number = 480,
                CostPrice = 15,
                Date = DateTime.Now
            };

            modelBuilder.Entity<Product>().HasData(
                product1,
                product2,
                product3
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
