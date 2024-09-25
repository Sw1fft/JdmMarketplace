using JdmMarketplace.Services.CatalogAPI.Mappings;
using JdmMarketplace.Services.CatalogApplication.Mappings;
using JdmMarketplace.Services.CatalogApplication.Services;
using JdmMarketplace.Services.CatalogData;
using JdmMarketplace.Services.CatalogDomain.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddAutoMapper(typeof(CatalogProfile));
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<CatalogDbContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();