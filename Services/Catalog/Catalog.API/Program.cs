using Catalog.Application;
using Catalog.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructureServices(settings =>
{
    settings.ConnectionString = builder.Configuration.GetValue<string>("MongoDbSettings:ConnectionString");
    settings.DatabaseName = builder.Configuration.GetValue<string>("MongoDbSettings:DatabaseName");
    settings.ProductsCollectionName = builder.Configuration.GetValue<string>("MongoDbSettings:ProductsCollectionName");
    settings.BrandsCollectionName = builder.Configuration.GetValue<string>("MongoDbSettings:BrandsCollectionName");
    settings.TypesCollectionName = builder.Configuration.GetValue<string>("MongoDbSettings:TypesCollectionName");
});

builder.Services.AddApplicationServices();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();