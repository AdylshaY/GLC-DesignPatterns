using FactoryMethodDP.FactoryMethods;
using FactoryMethodDP.Models;

IVehicleFactory factory = new CarFactory();
IVehicle myVehicle = factory.CreateVehicle();
myVehicle.Drive();

Console.WriteLine(new string('-', 30));

factory = new PlaneFactory();
myVehicle = factory.CreateVehicle();
myVehicle.Drive();
