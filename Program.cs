using Bangazon_ECommerce_ServerSide.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Bangazon_ECommerce_ServerSide;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<Bangazon_ECommerceDbContext>(builder.Configuration["Bangazon_ECommerceDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.MapGet("/products", (Bangazon_ECommerceDbContext db) =>
{
    return db.Products.ToList();
});

app.MapDelete("/products/{ProductId}", (Bangazon_ECommerceDbContext db, int ProductId) =>
{
    Product deleteProduct = db.Products.FirstOrDefault( c => c.Id == ProductId );
    if ( deleteProduct == null)
    {
        return Results.NotFound();
    }

    db.Products.Remove(deleteProduct);
    db.SaveChanges();
    return Results.NoContent();
});

app.MapPost("/products", (Bangazon_ECommerceDbContext db, Product products) =>
{
    db.Products.Add(products);
    db.SaveChanges();
    return Results.Created($"/products/{products.Id}", products);
});

//Get single product
app.MapGet("/products/{ProductId}", (Bangazon_ECommerceDbContext db, int ProductId) =>
{
    return db.Products.First( c => c.Id == ProductId );
});

app.MapPut("/products/update/{ProductId}", (Bangazon_ECommerceDbContext db, int ProductId, Product products) =>
{
    Product PatchProducts = db.Products.First(c => c.Id == ProductId);
    if ( PatchProducts == null )
    {
        return Results.NotFound();
    }
    PatchProducts.Name = products.Name;
    PatchProducts.Description = products.Description;
    PatchProducts.imageUrl = products.imageUrl;
    PatchProducts.price = products.price;
    PatchProducts.isSoldOut = products.isSoldOut;

    db.SaveChanges();
    return Results.NoContent();
});

app.MapGet("/payments", (Bangazon_ECommerceDbContext db) =>
{
    return db.PaymentTypes.ToList();
});

app.MapDelete("/payments/{payId}", ( Bangazon_ECommerceDbContext db, int payId) =>
{
    PaymentType deleteType = db.PaymentTypes.FirstOrDefault(pt => pt.Id == payId);
    if ( deleteType == null )
    {
        return Results.NotFound();
    }
    db.PaymentTypes.Remove(deleteType);
    db.SaveChanges();
    return Results.NoContent();
});

app.MapPost("/payment", ( Bangazon_ECommerceDbContext db, int payId, PaymentType paymentTypes ) =>
{
    db.PaymentTypes.Add(paymentTypes);
    db.SaveChanges();
    return Results.NoContent();
});

app.MapPut("/payment/{payId}", (Bangazon_ECommerceDbContext db, int payId, PaymentType paymentTypes ) =>
{
    PaymentType updateType = db.PaymentTypes.FirstOrDefault( pt => pt.Id == payId);
    if ( updateType == null )
    {
        return Results.NotFound();
    }

    updateType.Name = paymentTypes.Name;
    db.SaveChanges();
    return Results.NoContent();
});

app.Run();
