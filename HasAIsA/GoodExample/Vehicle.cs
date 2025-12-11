using HasAIsA.GoodExample.DefaultBehaviors;
using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample
{
    public class Vehicle
    {
        protected IBackwardBehavior BackwardBehavior = new DefaultBackwardBehavior();
        protected IForwardBehavior ForwardBehavior = new DefaultForwardBehavior();

        public void Forward()
        {
            ForwardBehavior.Forward();
        }

        public void Backward()
        {
            BackwardBehavior.Backward();
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle Stop");
        }

        public void ChangeBackwardBehavior(IBackwardBehavior backwardBehavior)
        {
            BackwardBehavior = backwardBehavior;
        }

        public void ChangeForwardBehavior(IForwardBehavior forwardBehavior)
        {
            ForwardBehavior = forwardBehavior;
        }
    }
}
