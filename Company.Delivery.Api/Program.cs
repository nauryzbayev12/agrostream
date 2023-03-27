using Company.Delivery.Api.AppStart;
using Company.Delivery.Database;
using Company.Delivery.Domain;
using Company.Delivery.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DeliveryDbContext>(options => options.UseNpgsql(connection, b => b.MigrationsAssembly("Company.Delivery.Database")));

builder.Services.AddDeliveryControllers();
builder.Services.AddDeliveryApi();
builder.Services.AddTransient<IWaybillService, WaybillService>();

var app = builder.Build();

app.UseDeliveryApi();
app.MapControllers();

app.Run();
app.MapControllers();
