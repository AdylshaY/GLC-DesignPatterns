using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.CarBehaivor
{
    public class CarLeftBehavior : ILeftBehavior
    {
        public void Left()
        {
            Console.WriteLine("Car left");
        }
    }
}
