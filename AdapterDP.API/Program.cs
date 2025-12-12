using AdapterDP.API.ImageProcess;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHttpContextAccessor();

Dictionary<bool, IImageProcess> imageProcessDict = new()
{
    { true, new LazziyaImageResizeAdapter() },
    {false, new BasicImageProcess() }
};

builder.Services.AddScoped<IImageProcess>(sp =>
{
    var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();
    var httpContext = httpContextAccessor.HttpContext;
    //var isAuth = httpContext.User.Identity.IsAuthenticated;
    //var userId = httpContext.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier);

    CountProvider.Count++;
    return imageProcessDict[CountProvider.Count % 2 == 0];
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/upload", ([FromServices] IImageProcess imageProcess, IFormFile formFile) =>
{
    imageProcess.AddWatermark("Hello", "image.jpg", formFile.OpenReadStream());
    return Results.Ok();
})
.DisableAntiforgery()
.WithName("Upload");

app.Run();
