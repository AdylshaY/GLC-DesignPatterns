using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.CarBehaivor
{
    public class CarBackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("Car backward");
        }
    }
}
