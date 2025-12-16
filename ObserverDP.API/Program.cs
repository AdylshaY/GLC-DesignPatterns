using Microsoft.AspNetCore.Mvc;
using ObserverDP.API.Example1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped((sp) =>
{
    var userSubject = new UserSubject();
    userSubject.RegisterObserver(new EmailService());
    userSubject.RegisterObserver(new SmsService());
    userSubject.RegisterObserver(new NotificationService());
    return userSubject;
});
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/api/user", async ([FromServices] UserService userService) =>
{
    await userService.CreateUser("John Doe", "john@doe.com", "1234567890");
    return Results.Ok("User created and observers notified.");
})
.WithName("CreateUser");

app.Run();
