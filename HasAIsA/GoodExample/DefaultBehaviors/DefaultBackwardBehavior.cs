using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.DefaultBehaviors
{
    public class DefaultBackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("Vehicle Backward (Default)");
        }
    }
}
