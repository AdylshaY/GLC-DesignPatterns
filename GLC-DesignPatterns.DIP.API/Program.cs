using Bad = GLC_DesignPatterns.DIP.API.BadExample;
using Good = GLC_DesignPatterns.DIP.API.GoodExample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<Good.Services.IProductService, Good.Services.ProductService>();
builder.Services.AddScoped<Good.Repositories.IProductRepository, Good.Repositories.ProductRepository>();

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/bad-products", () =>
{
    var productService = new Bad.Services.ProductService();
    return productService.GetAllProducts();
})
.WithName("BadProducts");

app.MapGet("/good-products", (Good.Services.IProductService productService) =>
{
    return productService.GetAllProducts();
})
.WithName("GoodProducts");

app.Run();
