using AdapterDP.API.ImageProcess;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IImageProcess, LazziyaImageResizeAdapter>();

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
