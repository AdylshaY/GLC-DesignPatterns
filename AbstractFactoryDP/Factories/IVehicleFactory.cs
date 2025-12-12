using AbstractFactoryDP.Interfaces;

namespace AbstractFactoryDP.Factories
{
    public interface IVehicleFactory
    {
        IEngine CreateEngine();
        ITransmission CreateTransmission();
        IChassis CreateChassis();
    }
}
