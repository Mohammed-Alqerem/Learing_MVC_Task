using CRUDTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Data Model
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;DataBase=CRUDTaskDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
         
        // Seeding Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
    new Product
    {
        Id = 1,
        Name = "Samsung Galaxy S24",
        Description = "Samsung flagship smartphone with excellent performance and camera.",
        Price = 799.99m,
        Rate = 4.7
    },

    new Product
    {
        Id = 2,
        Name = "iPhone 15",
        Description = "Apple smartphone with A16 Bionic chip and advanced camera system.",
        Price = 699.99m,
        Rate = 4.8
    },

    new Product
    {
        Id = 3,
        Name = "Google Pixel 8",
        Description = "Google smartphone with an excellent camera and clean Android experience.",
        Price = 599.99m,
        Rate = 4.6
    },

    new Product
    {
        Id = 4,
        Name = "Xiaomi 14",
        Description = "Powerful Xiaomi smartphone with a high-quality AMOLED display.",
        Price = 649.99m,
        Rate = 4.5
    },

    new Product
    {
        Id = 5,
        Name = "OnePlus 12",
        Description = "Fast Android smartphone with a powerful processor and large battery.",
        Price = 749.99m,
        Rate = 4.6
    },

    new Product
    {
        Id = 6,
        Name = "Samsung Galaxy A55",
        Description = "Mid-range Samsung smartphone with a great display and long battery life.",
        Price = 449.99m,
        Rate = 4.4
    },

    new Product
    {
        Id = 7,
        Name = "iPhone 14",
        Description = "Reliable Apple smartphone with a powerful processor and great camera.",
        Price = 599.99m,
        Rate = 4.7
    },

    new Product
    {
        Id = 8,
        Name = "Xiaomi Redmi Note 13",
        Description = "Affordable smartphone with AMOLED display and strong battery performance.",
        Price = 299.99m,
        Rate = 4.3
    },

    new Product
    {
        Id = 9,
        Name = "Nothing Phone 2",
        Description = "Modern Android smartphone with a unique design and smooth performance.",
        Price = 549.99m,
        Rate = 4.4
    },

    new Product
    {
        Id = 10,
        Name = "OnePlus Nord 4",
        Description = "Affordable performance-focused smartphone with a premium design.",
        Price = 399.99m,
        Rate = 4.5
    }
);
        }
    }
}

        