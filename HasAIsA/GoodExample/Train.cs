using HasAIsA.GoodExample.TrainBehavior;

namespace HasAIsA.GoodExample
{
    public class Train : Vehicle
    {
        public Train()
        {
            BackwardBehavior = new TrainBackwardBehavior();
        }
    }
}
