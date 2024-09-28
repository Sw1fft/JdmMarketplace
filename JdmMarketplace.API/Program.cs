using JdmMarketplace.Services.CatalogApplication.Mappings;
using JdmMarketplace.Services.CatalogApplication.Services;
using JdmMarketplace.Services.CatalogDomain.Abstractions;
using JdmMarketplace.Services.CatalogAPI.Mappings;
using JdmMarketplace.Services.CatalogData;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddDbContext<CatalogDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(CatalogDbContext)));
});

builder.Services.AddAutoMapper(typeof(CatalogProfile));
builder.Services.AddAutoMapper(typeof(MappingProfile));

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