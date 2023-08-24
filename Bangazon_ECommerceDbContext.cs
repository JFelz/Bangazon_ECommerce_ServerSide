using Bangazon_ECommerce_ServerSide.Models;
using Microsoft.EntityFrameworkCore;


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
                new Customer {Id = 1, Name = "Noah Tidmore", Email = "ntidmore@gmail.com", PhoneNumber = 4314566790, PaymentType_Id = "Visa", imageUrl = "https://media.licdn.com/dms/image/D4E03AQFKM6pqd6V4yQ/profile-displayphoto-shrink_800_800/0/1690910283553?e=1698278400&v=beta&t=99sYtrRA4EbyMykv0G-1v_KSREqCqC5kOIrut5eV6Nw"}, 
            });
        }
    }
}
