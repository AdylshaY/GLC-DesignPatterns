using FactoryMethodDP.Models;

namespace FactoryMethodDP.FactoryMethods
{
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
