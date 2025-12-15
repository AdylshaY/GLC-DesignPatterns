using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProxyDP.API.Middlewares;
using ProxyDP.API.Repositories;
using ProxyDP.API.Services;
using ProxyDP.API.Services.Proxies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

//builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<IProductService>(sp =>
{
    var productRepository = sp.GetRequiredService<IProductRepository>();
    var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
    var userManager = sp.GetRequiredService<UserManager<AppUser>>();
    var productService = new ProductService(productRepository);
    return new ProductServiceAccessProxy(productService, httpContextAccessor, userManager);
});

var app = builder.Build();

app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/api/products", async ([FromServices] IProductService productService, CreateProductRequest request) =>
{
    var result = await productService.CreateAsync(request);
    return Results.Ok(result);
})
.WithName("Products");

app.Run();