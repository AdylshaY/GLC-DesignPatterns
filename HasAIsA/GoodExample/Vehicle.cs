using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample
{
    public class Vehicle
    {
        protected IBackwardBehavior BackwardBehavior = null!;
        protected IForwardBehavior? ForwardBehavior;

        public void Forward()
        {
            if (ForwardBehavior is not null)
            {
                ForwardBehavior.Forward();
            }
            else
            {
                Console.WriteLine("Vehicle Forward");
            }
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
