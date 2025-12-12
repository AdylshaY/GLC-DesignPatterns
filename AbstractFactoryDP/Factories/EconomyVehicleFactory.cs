using AbstractFactoryDP.Interfaces;
using AbstractFactoryDP.Products;

namespace AbstractFactoryDP.Factories
{
    public class EconomyVehicleFactory : IVehicleFactory
    {
        public IEngine CreateEngine() => new EconomyEngine();
        public ITransmission CreateTransmission() => new EconomyTransmission();
        public IChassis CreateChassis() => new EconomyChassis();
    }
}
