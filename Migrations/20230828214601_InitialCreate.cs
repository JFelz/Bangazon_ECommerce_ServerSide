using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangazon_ECommerce_ServerSide.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    PaymentType_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    imageUrl = table.Column<string>(type: "text", nullable: false),
                    PaymentType_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    imageUrl = table.Column<string>(type: "text", nullable: false),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
                    isSoldOut = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellerOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    SellerId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SellerPaymentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    PaymentType_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerPaymentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    imageUrl = table.Column<string>(type: "text", nullable: false),
                    PaymentType_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    DatePurchased = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    OrderStatusId = table.Column<int>(type: "integer", nullable: false),
                    StatusUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Traditional" },
                    { 2, "Infrared" },
                    { 3, "Steam" },
                    { 4, "Wood-Burning" },
                    { 5, "Electric" },
                    { 6, "Homemade" }
                });

            migrationBuilder.InsertData(
                table: "CustomerPaymentType",
                columns: new[] { "Id", "CustomerId", "PaymentType_Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 4 },
                    { 4, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "CustomerProduct",
                columns: new[] { "Id", "CustomerId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name", "PaymentType_Id", "PhoneNumber", "imageUrl" },
                values: new object[,]
                {
                    { 1, "ntidmore@gmail.com", "Noah Tidmore", 1, 4314566790L, "https://media.licdn.com/dms/image/D4E03AQFKM6pqd6V4yQ/profile-displayphoto-shrink_800_800/0/1690910283553?e=1698278400&v=beta&t=99sYtrRA4EbyMykv0G-1v_KSREqCqC5kOIrut5eV6Nw" },
                    { 2, "jfelz@gmail.com", "Jovanni Feliz", 2, 6038206536L, "https://media.licdn.com/dms/image/D5603AQGOt-tl-ckCfg/profile-displayphoto-shrink_800_800/0/1690509369411?e=1698278400&v=beta&t=nqPo2qRequKNGPijkXxojE-cPzvpYuL7ApwscAkBEpQ" },
                    { 3, "vet.z@gmail.com", "Zoi Vetter", 4, 6937520463L, "https://blog.codersrank.io/wp-content/uploads/2021/03/joanna-otmianowska.webp" },
                    { 4, "danrox@gmail.com", "Danny Roxberry", 2, 4397548367L, "https://blog.codersrank.io/wp-content/uploads/2021/03/dani-roxberry.webp" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "Closed" },
                    { 3, "Paused" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Visa" },
                    { 2, "MasterCard" },
                    { 3, "Amex" },
                    { 4, "Discover" },
                    { 5, "Paypal" }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "SellerId", "imageUrl", "isSoldOut", "price" },
                values: new object[,]
                {
                    { 1, 2, "Relax at home in this Lifesauna Aspen Upgraded 2-Person Electric Infrared Sauna with 6 Dual Tech Infrared Heaters and Chromotherapy. It promotes better blood circulation and skin. The interlocking panels make for an easy installation.", "Lifesauna Electric Infrared Sauna", 5, "https://yourhomeupgraded.com/cdn/shop/products/DYN-6206-01_2_3x3_43d4dcc9-42d9-474f-b80b-13a2b8f39995_1024x1024@2x.jpg?v=1660666239", false, 1799.99m },
                    { 2, 3, "With a Golden Designs traditional steam sauna, you can turn that dream of your very own home spa into a reality.", "Canadian Red Cedar Traditional Steam Sauna", 3, "https://yourhomeupgraded.com/cdn/shop/products/GoldenDesigns-7289-01-11_1024x1024@2x.jpg?v=1661386470", false, 4999.99m },
                    { 3, 1, "Corner saunas are typically space-efficient, but that’s not the only reason to buy this particular sauna. This corner sauna for up to four people would be an excellent part of any home where well-being is important.", "Enlighten Sauna", 2, "https://yourhomeupgraded.com/cdn/shop/products/SunRise_4C-4_1024x1024@2x.jpg?v=1631730422", true, 9999.99m },
                    { 4, 5, "Scandia's Electric Barrel Sauna Kit combines technology with traditions. Our sauna barrel includes a Smart Sauna Wi-Fi Controller and a chromotherapy system to help you customize your sessions without limitations.", "Barrel Sauna Canopy with Electric Heater", 1, "https://saunas.com/cdn/shop/products/CANOPYBARRELSAUANA_750x750.jpg?v=1658159501", true, 10849.99m },
                    { 5, 4, "These organic rain-drop shaped outdoor saunas are the newest sensation to hit Canada. The extra head-space and wonderful design comes in various sizes and in Clear Western Red Cedar with endless options so you can customize your own outdoor sauna.", "Dundalk Leisure Craft Clear Cedar Pod Sauna", 2, "https://mysaunaworld.com/cdn/shop/products/SquareImage3_c2e7394a-3b97-4731-acc2-b8aa407e899e_700x.png?v=1652213323", false, 11949.99m }
                });

            migrationBuilder.InsertData(
                table: "SellerOrder",
                columns: new[] { "Id", "OrderId", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "SellerPaymentType",
                columns: new[] { "Id", "PaymentType_Id", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 3, 4 },
                    { 5, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Email", "Name", "PaymentType_Id", "PhoneNumber", "imageUrl" },
                values: new object[,]
                {
                    { 1, "james.moore@outlook.com", "James Moore", 1, 5559012345L, "https://images.squarespace-cdn.com/content/v1/5cf0d08d5fc69d000172462a/1602248693535-KTGCFTA50807510I5LVN/Tom+LinkedIn+Headshot+Profile+Picture.jpg?format=750w" },
                    { 2, "olivia.taylor@gmail.com", "Olivia Taylor", 1, 6460123456L, "https://writestylesonline.com/wp-content/uploads/2019/01/What-To-Wear-For-Your-Professional-Profile-Picture-or-Headshot.jpg" },
                    { 3, "emma.wilson@hotmail.com", "Emma Wilson", 2, 8888901234L, "https://images.unsplash.com/photo-1573496358961-3c82861ab8f4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2488&q=80" },
                    { 4, "michael.williams@hotmail.com", "Michael Williams", 3, 7773456789L, "https://images.unsplash.com/photo-1519085360753-af0119f7cbe7?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2487&q=80" },
                    { 5, "robert.miller@yahoo.com", "Robert Miller", 4, 7777890123L, "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2487&q=80" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "DatePurchased", "OrderStatusId", "ProductId", "SellerId", "StatusUpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerId",
                table: "Orders",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CustomerPaymentType");

            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "SellerOrder");

            migrationBuilder.DropTable(
                name: "SellerPaymentType");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
