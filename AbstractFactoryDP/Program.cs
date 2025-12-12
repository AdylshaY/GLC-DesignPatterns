using AbstractFactoryDP;
using AbstractFactoryDP.Factories;

IVehicleFactory sportFactory = new SportVehicleFactory();
VehicleAssemblyLine sportLine = new VehicleAssemblyLine(sportFactory);

Console.WriteLine("Order: Sport Vehicle");
sportLine.BuildAndVerifyVehicle();


IVehicleFactory economyFactory = new EconomyVehicleFactory();
VehicleAssemblyLine economyLine = new VehicleAssemblyLine(economyFactory);

Console.WriteLine("Order: Economy Vehicle");
economyLine.BuildAndVerifyVehicle();

Console.ReadLine();