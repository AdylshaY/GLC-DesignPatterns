using FactoryMethodDP.Models;

namespace FactoryMethodDP.FactoryMethods
{
    public class PlaneFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Plane();
        }
    }
}
