using CompositeDP.API.CompositeEFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//using CompositeDP.API.Example;
//var fileManager = new FileManager();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("CompositeDPDB"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var appDbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    SeedData.Seed(appDbContext);
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/api/employees", ([FromServices] AppDbContext dbContext) =>
{
    //var rootDepartment = dbContext.Departments.First(x => x.ParentDepartmentId == null);
    //rootDepartment.Print();

    var rootDepartment = dbContext.Departments.Include(d => d.Manager)
        .Include(d => d.Employees)
        .Include(d => d.SubDepartments)
        .First(x => x.ParentDepartmentId == null);

    rootDepartment.Print();
})
.WithName("GetEmployees");

app.Run();

