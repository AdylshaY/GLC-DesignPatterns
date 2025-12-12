using AbstractFactoryDP.Interfaces;
using AbstractFactoryDP.Products;

namespace AbstractFactoryDP.Factories
{
    public class SportVehicleFactory : IVehicleFactory
    {
        public IEngine CreateEngine() => new SportEngine();
        public ITransmission CreateTransmission() => new SportTransmission();
        public IChassis CreateChassis() => new SportChassis();
    }
}
