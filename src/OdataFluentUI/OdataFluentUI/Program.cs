using Microsoft.EntityFrameworkCore;
using OdataFluentUI.Data.Models;
using Microsoft.AspNetCore.OData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Adventureworks2019Context>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).EnableSensitiveDataLogging());

builder.Services.AddControllers()
   .AddOData(opt => opt.EnableQueryFeatures(maxTopValue:5000)
   .AddRouteComponents("odata", OdataFluentUI.OdataModelBuilder.ModelBuilder.GetEdmModel()));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseHttpLogging();
}

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
