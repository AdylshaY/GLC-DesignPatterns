using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.TrainBehavior
{
    public class TrainBackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("Train backward");
        }
    }
}
