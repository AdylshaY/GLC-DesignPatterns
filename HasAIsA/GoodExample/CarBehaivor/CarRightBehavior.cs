using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.CarBehaivor
{
    public class CarRightBehavior : IRightBehavior
    {
        public void Right()
        {
            Console.WriteLine("Car right");
        }
    }
}
