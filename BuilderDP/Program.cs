using BuilderDP.Builder;
using BuilderDP.Director;
using BuilderDP.Models;

var builder = new CustomCarBuilder();

Console.WriteLine("1. Custom Order (Fluent Interface):");

Car myCustomCar = builder
    .SetBrand("Toyota")
    .SetEngine("Hybrid 1.8", 140)
    .SetTransmission("CVT Automatic")
    .SetColor("Pearl White")
    .AddGPS()
    .Build();

myCustomCar.DisplaySpecs();

Console.WriteLine("2. Standard Order via Director (Sports Car):");

var director = new FleetDirector();

director.ConstructSportsCar(builder);
Car luxuryCar = builder.Build();

luxuryCar.DisplaySpecs();

Console.WriteLine("3. Standard Order via Director (SUV):");

director.ConstructSUV(builder);
Car familyCar = builder.Build();

familyCar.DisplaySpecs();
