WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WarehouseContext>(options =>
              options.UseSqlite(builder.Configuration.GetConnectionString("SQLiteConnection")).EnableSensitiveDataLogging());

builder.Services.AddControllers()
   .AddOData(opt => opt.EnableQueryFeatures(maxTopValue:500)
   .AddRouteComponents("odata", OdataFluentUI.OdataModelBuilder.ModelBuilder.GetEdmModel(), new DefaultODataBatchHandler()));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    string basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
    options.IncludeXmlComments(Path.Combine(basePath, "OdataFluentUI.xml"), true);
    options.IncludeXmlComments(Path.Combine(basePath, "OdataFluentUI.Data.xml"), true); 
});

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
});

WebApplication app = builder.Build();

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
