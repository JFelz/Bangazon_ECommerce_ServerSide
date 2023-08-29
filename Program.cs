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

app.Run();
