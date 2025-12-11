using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.DefaultBehaviors
{
    public class DefaultForwardBehavior : IForwardBehavior
    {
        public void Forward()
        {
            Console.WriteLine("Vehicle Forward (Default)");
        }
    }
}
