﻿// <auto-generated />
using System;
using Bangazon_ECommerce_ServerSide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangazon_ECommerce_ServerSide.Migrations
{
    [DbContext(typeof(Bangazon_ECommerceDbContext))]
    [Migration("20230828214601_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Traditional"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Infrared"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Steam"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Wood-Burning"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Electric"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Homemade"
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PaymentType_Id")
                        .HasColumnType("integer");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ntidmore@gmail.com",
                            Name = "Noah Tidmore",
                            PaymentType_Id = 1,
                            PhoneNumber = 4314566790L,
                            imageUrl = "https://media.licdn.com/dms/image/D4E03AQFKM6pqd6V4yQ/profile-displayphoto-shrink_800_800/0/1690910283553?e=1698278400&v=beta&t=99sYtrRA4EbyMykv0G-1v_KSREqCqC5kOIrut5eV6Nw"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jfelz@gmail.com",
                            Name = "Jovanni Feliz",
                            PaymentType_Id = 2,
                            PhoneNumber = 6038206536L,
                            imageUrl = "https://media.licdn.com/dms/image/D5603AQGOt-tl-ckCfg/profile-displayphoto-shrink_800_800/0/1690509369411?e=1698278400&v=beta&t=nqPo2qRequKNGPijkXxojE-cPzvpYuL7ApwscAkBEpQ"
                        },
                        new
                        {
                            Id = 3,
                            Email = "vet.z@gmail.com",
                            Name = "Zoi Vetter",
                            PaymentType_Id = 4,
                            PhoneNumber = 6937520463L,
                            imageUrl = "https://blog.codersrank.io/wp-content/uploads/2021/03/joanna-otmianowska.webp"
                        },
                        new
                        {
                            Id = 4,
                            Email = "danrox@gmail.com",
                            Name = "Danny Roxberry",
                            PaymentType_Id = 2,
                            PhoneNumber = 4397548367L,
                            imageUrl = "https://blog.codersrank.io/wp-content/uploads/2021/03/dani-roxberry.webp"
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.CustomerPaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentType_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CustomerPaymentType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            PaymentType_Id = 1
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            PaymentType_Id = 2
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            PaymentType_Id = 4
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 4,
                            PaymentType_Id = 2
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.CustomerProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CustomerProduct");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DatePurchased")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StatusUpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DatePurchased = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatusId = 1,
                            ProductId = 4,
                            SellerId = 2,
                            StatusUpdateDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            DatePurchased = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderStatusId = 1,
                            ProductId = 2,
                            SellerId = 1,
                            StatusUpdateDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Open"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Closed"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Paused"
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Visa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "MasterCard"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Amex"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Discover"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Paypal"
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isSoldOut")
                        .HasColumnType("boolean");

                    b.Property<decimal>("price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Relax at home in this Lifesauna Aspen Upgraded 2-Person Electric Infrared Sauna with 6 Dual Tech Infrared Heaters and Chromotherapy. It promotes better blood circulation and skin. The interlocking panels make for an easy installation.",
                            Name = "Lifesauna Electric Infrared Sauna",
                            SellerId = 5,
                            imageUrl = "https://yourhomeupgraded.com/cdn/shop/products/DYN-6206-01_2_3x3_43d4dcc9-42d9-474f-b80b-13a2b8f39995_1024x1024@2x.jpg?v=1660666239",
                            isSoldOut = false,
                            price = 1799.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "With a Golden Designs traditional steam sauna, you can turn that dream of your very own home spa into a reality.",
                            Name = "Canadian Red Cedar Traditional Steam Sauna",
                            SellerId = 3,
                            imageUrl = "https://yourhomeupgraded.com/cdn/shop/products/GoldenDesigns-7289-01-11_1024x1024@2x.jpg?v=1661386470",
                            isSoldOut = false,
                            price = 4999.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Corner saunas are typically space-efficient, but that’s not the only reason to buy this particular sauna. This corner sauna for up to four people would be an excellent part of any home where well-being is important.",
                            Name = "Enlighten Sauna",
                            SellerId = 2,
                            imageUrl = "https://yourhomeupgraded.com/cdn/shop/products/SunRise_4C-4_1024x1024@2x.jpg?v=1631730422",
                            isSoldOut = true,
                            price = 9999.99m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Description = "Scandia's Electric Barrel Sauna Kit combines technology with traditions. Our sauna barrel includes a Smart Sauna Wi-Fi Controller and a chromotherapy system to help you customize your sessions without limitations.",
                            Name = "Barrel Sauna Canopy with Electric Heater",
                            SellerId = 1,
                            imageUrl = "https://saunas.com/cdn/shop/products/CANOPYBARRELSAUANA_750x750.jpg?v=1658159501",
                            isSoldOut = true,
                            price = 10849.99m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "These organic rain-drop shaped outdoor saunas are the newest sensation to hit Canada. The extra head-space and wonderful design comes in various sizes and in Clear Western Red Cedar with endless options so you can customize your own outdoor sauna.",
                            Name = "Dundalk Leisure Craft Clear Cedar Pod Sauna",
                            SellerId = 2,
                            imageUrl = "https://mysaunaworld.com/cdn/shop/products/SquareImage3_c2e7394a-3b97-4731-acc2-b8aa407e899e_700x.png?v=1652213323",
                            isSoldOut = false,
                            price = 11949.99m
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ProductOrder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PaymentType_Id")
                        .HasColumnType("integer");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "james.moore@outlook.com",
                            Name = "James Moore",
                            PaymentType_Id = 1,
                            PhoneNumber = 5559012345L,
                            imageUrl = "https://images.squarespace-cdn.com/content/v1/5cf0d08d5fc69d000172462a/1602248693535-KTGCFTA50807510I5LVN/Tom+LinkedIn+Headshot+Profile+Picture.jpg?format=750w"
                        },
                        new
                        {
                            Id = 2,
                            Email = "olivia.taylor@gmail.com",
                            Name = "Olivia Taylor",
                            PaymentType_Id = 1,
                            PhoneNumber = 6460123456L,
                            imageUrl = "https://writestylesonline.com/wp-content/uploads/2019/01/What-To-Wear-For-Your-Professional-Profile-Picture-or-Headshot.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Email = "emma.wilson@hotmail.com",
                            Name = "Emma Wilson",
                            PaymentType_Id = 2,
                            PhoneNumber = 8888901234L,
                            imageUrl = "https://images.unsplash.com/photo-1573496358961-3c82861ab8f4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2488&q=80"
                        },
                        new
                        {
                            Id = 4,
                            Email = "michael.williams@hotmail.com",
                            Name = "Michael Williams",
                            PaymentType_Id = 3,
                            PhoneNumber = 7773456789L,
                            imageUrl = "https://images.unsplash.com/photo-1519085360753-af0119f7cbe7?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2487&q=80"
                        },
                        new
                        {
                            Id = 5,
                            Email = "robert.miller@yahoo.com",
                            Name = "Robert Miller",
                            PaymentType_Id = 4,
                            PhoneNumber = 7777890123L,
                            imageUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2487&q=80"
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.SellerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SellerOrder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            SellerId = 2
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 2,
                            SellerId = 1
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.SellerPaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PaymentType_Id")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("SellerPaymentType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PaymentType_Id = 1,
                            SellerId = 1
                        },
                        new
                        {
                            Id = 2,
                            PaymentType_Id = 1,
                            SellerId = 2
                        },
                        new
                        {
                            Id = 3,
                            PaymentType_Id = 2,
                            SellerId = 3
                        },
                        new
                        {
                            Id = 4,
                            PaymentType_Id = 3,
                            SellerId = 4
                        },
                        new
                        {
                            Id = 5,
                            PaymentType_Id = 4,
                            SellerId = 5
                        });
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Order", b =>
                {
                    b.HasOne("Bangazon_ECommerce_ServerSide.Models.Customer", "customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon_ECommerce_ServerSide.Models.OrderStatus", "status")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon_ECommerce_ServerSide.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bangazon_ECommerce_ServerSide.Models.Seller", "seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("product");

                    b.Navigation("seller");

                    b.Navigation("status");
                });

            modelBuilder.Entity("Bangazon_ECommerce_ServerSide.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
