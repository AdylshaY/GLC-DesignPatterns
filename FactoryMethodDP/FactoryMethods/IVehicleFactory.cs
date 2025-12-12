using FactoryMethodDP.Models;

namespace FactoryMethodDP.FactoryMethods
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
