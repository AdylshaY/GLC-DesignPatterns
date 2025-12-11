using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.PlaneBehavior
{
    public class PlaneForwardBehavior : IForwardBehavior
    {
        public void Forward()
        {
            Console.WriteLine("Plane Fly");
        }
    }
}
