using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SimpleProductApi.Data;

var builder = WebApplication.CreateBuilder(args);

// ✅ Hardcoded SQL Server connection string
var connectionString = "Server=localhost\\SqlServer;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;";

// ✅ Register EF Core DbContext with SQL Server
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(connectionString));

// ✅ Register controller services
builder.Services.AddControllers();

// ✅ Swagger service registration
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SimpleProduct API",
        Version = "v1"
    });
});

var app = builder.Build();

// ✅ Enable Swagger in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "SimpleProduct API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
