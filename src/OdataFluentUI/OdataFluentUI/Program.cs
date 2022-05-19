using GrpcService.Services;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;
using System.Text.Json.Serialization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<WarehouseContext>(options =>
              options.UseSqlite(builder.Configuration.GetConnectionString("SQLiteConnection")).EnableSensitiveDataLogging());

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(System.Text.Json.JsonNamingPolicy.CamelCase));
        //options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        //options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;


    })
   .AddOData(opt => opt.EnableQueryFeatures(maxTopValue:500)
   .AddRouteComponents("odata", OdataFluentUI.OdataModelBuilder.ModelBuilder.GetEdmModel(), new DefaultODataBatchHandler()));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services
    .AddSwaggerGen(options => {
    options.SwaggerDoc("odata", new OpenApiInfo() { Title = "OdataApi", Version = "v1" });
    options.SwaggerDoc("document", new OpenApiInfo() { Title = "WebApi", Version = "v1" });
    //设置要展示的接口
    options.DocInclusionPredicate((docName, apiDes) =>
    {
        if (!apiDes.TryGetMethodInfo(out MethodInfo method))
            return false;
        var version = method.DeclaringType.GetCustomAttributes(true).OfType<ApiExplorerSettingsAttribute>().Select(m => m.GroupName);
        if (docName == "v1" && !version.Any())
            return true;
        var actionVersion = method.GetCustomAttributes(true).OfType<ApiExplorerSettingsAttribute>().Select(m => m.GroupName);
        if (actionVersion.Any())
            return actionVersion.Any(v => v == docName);
        return version.Any(v => v == docName);
    });
    string basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);
    options.IncludeXmlComments(Path.Combine(basePath, "OdataFluentUI.xml"), true);
    options.IncludeXmlComments(Path.Combine(basePath, "OdataFluentUI.Data.xml"), true);
});

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<LiteDatabase>((provider) =>
{
    return new LiteDatabase(builder.Configuration.GetConnectionString("LiteDbConnection"));
});
builder.Services.AddScoped<IDocumentRepository, DocumentRepository>();

builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();

WebApplication app = builder.Build();
app.MapGrpcReflectionService();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI(o =>
    {
        o.SwaggerEndpoint("/swagger/odata/swagger.json", "OdataApi");
        o.SwaggerEndpoint("/swagger/odata/swagger.yaml", "OdataApi");
        o.SwaggerEndpoint("/swagger/document/swagger.json", "WebApi");
        o.SwaggerEndpoint("/swagger/document/swagger.yaml", "WebApi");
    });

    //app.UseHttpLogging();
//}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.MapGrpcService<ConfigService>();

app.Run();
