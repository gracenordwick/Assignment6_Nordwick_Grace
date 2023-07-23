using Microsoft.EntityFrameworkCore;
using StoreDatabase.Entities;
using StoreDatabase.Migrations;

namespace StoreDatabase.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLineItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(

                new Product { ProductId = 1, ProductName = "Cheese Pizza", ProductPrice = 9.0f },
                new Product { ProductId = 2, ProductName = "Pepperoni Pizza", ProductPrice = 10.0f },
                new Product { ProductId = 3, ProductName = "Cheesy Bread Sticks", ProductPrice = 11.0f },
                new Product { ProductId = 4, ProductName = "Supreme Pizza", ProductPrice = 13.0f },
                new Product { ProductId = 5, ProductName = "Soft Drink", ProductPrice = 2.0f },
                new Product { ProductId = 6, ProductName = "Salad", ProductPrice = 3.0f }
          );

        }

    }

}
