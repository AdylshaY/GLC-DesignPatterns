using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.CarBehaivor
{
    internal class CarForwardBehavior : IForwardBehavior
    {
        public void Forward()
        {
            Console.WriteLine("Car Forward");
        }
    }
}
