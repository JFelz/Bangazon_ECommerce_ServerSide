using Microsoft.EntityFrameworkCore;
using Bangazon_ECommerce_ServerSide.Models;
using System.Collections.Generic;
using System;


namespace Bangazon_ECommerce_ServerSide
{
    public class Bangazon_ECommerceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set;}

        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Category> Categories { get; set; }

        public Bangazon_ECommerceDbContext(DbContextOptions<Bangazon_ECommerceDbContext> context) : base(context) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer {Id = 1, Name = "Noah Tidmore", Email = "ntidmore@gmail.com", PhoneNumber = 4314566790, PaymentType_Id = 1, imageUrl = "https://media.licdn.com/dms/image/D4E03AQFKM6pqd6V4yQ/profile-displayphoto-shrink_800_800/0/1690910283553?e=1698278400&v=beta&t=99sYtrRA4EbyMykv0G-1v_KSREqCqC5kOIrut5eV6Nw"}, 
                new Customer {Id = 2, Name = "Jovanni Feliz", Email = "jfelz@gmail.com", PhoneNumber = 6038206536, PaymentType_Id = 2, imageUrl = "https://media.licdn.com/dms/image/D5603AQGOt-tl-ckCfg/profile-displayphoto-shrink_800_800/0/1690509369411?e=1698278400&v=beta&t=nqPo2qRequKNGPijkXxojE-cPzvpYuL7ApwscAkBEpQ"},
                new Customer {Id = 3, Name = "Zoi Vetter", Email = "vet.z@gmail.com", PhoneNumber = 6937520463, PaymentType_Id = 4, imageUrl = "https://blog.codersrank.io/wp-content/uploads/2021/03/joanna-otmianowska.webp"},
                new Customer {Id = 4, Name = "Danny Roxberry", Email = "danrox@gmail.com", PhoneNumber = 4397548367, PaymentType_Id = 2, imageUrl = "https://blog.codersrank.io/wp-content/uploads/2021/03/dani-roxberry.webp"},
            });

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product {Id = 1, SellerId = 5, CategoryId = 2, Name = "Lifesauna Electric Infrared Sauna", imageUrl = "https://yourhomeupgraded.com/cdn/shop/products/DYN-6206-01_2_3x3_43d4dcc9-42d9-474f-b80b-13a2b8f39995_1024x1024@2x.jpg?v=1660666239", price = 1799.99M, isSoldOut = false, Description = "Relax at home in this Lifesauna Aspen Upgraded 2-Person Electric Infrared Sauna with 6 Dual Tech Infrared Heaters and Chromotherapy. It promotes better blood circulation and skin. The interlocking panels make for an easy installation."},
                new Product {Id = 2, SellerId = 3, CategoryId = 3, Name = "Canadian Red Cedar Traditional Steam Sauna", imageUrl = "https://yourhomeupgraded.com/cdn/shop/products/GoldenDesigns-7289-01-11_1024x1024@2x.jpg?v=1661386470", price = 4999.99M, isSoldOut = false, Description = "With a Golden Designs traditional steam sauna, you can turn that dream of your very own home spa into a reality."},
                new Product {Id = 3, SellerId = 2, CategoryId = 1, Name = "Enlighten Sauna", imageUrl = "https://yourhomeupgraded.com/cdn/shop/products/SunRise_4C-4_1024x1024@2x.jpg?v=1631730422", price = 9999.99M, isSoldOut = true, Description = "Corner saunas are typically space-efficient, but that’s not the only reason to buy this particular sauna. This corner sauna for up to four people would be an excellent part of any home where well-being is important."},
                new Product {Id = 4, SellerId = 1, CategoryId = 5, Name = "Barrel Sauna Canopy with Electric Heater", imageUrl = "https://saunas.com/cdn/shop/products/CANOPYBARRELSAUANA_750x750.jpg?v=1658159501", price = 10849.99M, isSoldOut = true, Description = "Scandia's Electric Barrel Sauna Kit combines technology with traditions. Our sauna barrel includes a Smart Sauna Wi-Fi Controller and a chromotherapy system to help you customize your sessions without limitations."},
                new Product {Id = 5, SellerId = 4, CategoryId = 4, Name = "Dundalk Leisure Craft Clear Cedar Pod Sauna", imageUrl = "https://mysaunaworld.com/cdn/shop/products/SquareImage3_c2e7394a-3b97-4731-acc2-b8aa407e899e_700x.png?v=1652213323", price = 11949.99M, isSoldOut = false, Description = "These organic rain-drop shaped outdoor saunas are the newest sensation to hit Canada. The extra head-space and wonderful design comes in various sizes and in Clear Western Red Cedar with endless options so you can customize your own outdoor sauna."},
            });

            modelBuilder.Entity<Seller>().HasData(new Seller[]
            {
                new Seller {Id = 1, Name = "James Moore", Email = "james.moore@outlook.com", PhoneNumber = 5559012345, PaymentType_Id = 1, imageUrl = "https://images.squarespace-cdn.com/content/v1/5cf0d08d5fc69d000172462a/1602248693535-KTGCFTA50807510I5LVN/Tom+LinkedIn+Headshot+Profile+Picture.jpg?format=750w"},
                new Seller {Id = 2, Name = "Olivia Taylor", Email = "olivia.taylor@gmail.com", PhoneNumber = 6460123456, PaymentType_Id = 1, imageUrl = "https://writestylesonline.com/wp-content/uploads/2019/01/What-To-Wear-For-Your-Professional-Profile-Picture-or-Headshot.jpg"},
                new Seller {Id = 3, Name = "Emma Wilson", Email = "emma.wilson@hotmail.com", PhoneNumber = 8888901234, PaymentType_Id = 2, imageUrl = "https://images.unsplash.com/photo-1573496358961-3c82861ab8f4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2488&q=80"},
                new Seller {Id = 4, Name = "Michael Williams", Email = "michael.williams@hotmail.com", PhoneNumber = 7773456789, PaymentType_Id = 3, imageUrl = "https://images.unsplash.com/photo-1519085360753-af0119f7cbe7?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2487&q=80"},
                new Seller {Id = 5, Name = "Robert Miller", Email = "robert.miller@yahoo.com", PhoneNumber = 7777890123, PaymentType_Id = 4, imageUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2487&q=80"},
            });

            modelBuilder.Entity<PaymentType>().HasData(new PaymentType[]
            {
                new PaymentType {Id = 1, Name = "Visa" },
                new PaymentType {Id = 2, Name = "MasterCard" },
                new PaymentType {Id = 3, Name = "Amex" },
                new PaymentType {Id = 4, Name = "Discover" },
                new PaymentType {Id = 5, Name = "Paypal" },
            });
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category {Id = 1, Name = "Traditional" },
                new Category {Id = 2, Name = "Infrared" },
                new Category {Id = 3, Name = "Steam" },
                new Category {Id = 4, Name = "Wood-Burning" }, 
                new Category {Id = 5, Name = "Electric" },
                new Category {Id = 6, Name = "Homemade" },
            });

            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus[]
            {
                new OrderStatus {Id = 1, Name = "Open"},
                new OrderStatus {Id = 2, Name = "Closed"},
                new OrderStatus {Id = 3, Name = "Paused"},
            });

            modelBuilder.Entity<Order>().HasData(new Order[]
            {
                new Order {Id = 1, CustomerId = 1, SellerId = 2, ProductId = 4, OrderStatusId = 1, DatePurchased = new DateTime(2023, 1, 1), StatusUpdateDate = new DateTime(2023,1,1) },
            });

        }
    }
}
