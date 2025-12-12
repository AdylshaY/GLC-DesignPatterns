namespace FactoryMethodDP.Models
{
    public class Plane : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Plane - Drive");
        }
    }
}
