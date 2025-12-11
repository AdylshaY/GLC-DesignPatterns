using HasAIsA.GoodExample.CarBehaivor;
using HasAIsA.GoodExample.Interfaces;
using HasAIsA.GoodExample.TrainBehavior;

namespace HasAIsA.GoodExample
{
    public class SuperCarVehicle : Vehicle, ILeftOrRightBehavior
    {
        protected ILeftBehavior LeftBehavior { get; set; } = null!;
        protected IRightBehavior RightBehavior { get; set; } = null!;

        public SuperCarVehicle()
        {
            BackwardBehavior = new TrainBackwardBehavior();
            LeftBehavior = new CarLeftBehavior();
            RightBehavior = new CarRightBehavior();
        }
        public void Right()
        {
            RightBehavior.Right();
        }
        public void Left()
        {
            LeftBehavior.Left();
        }
    }
}
