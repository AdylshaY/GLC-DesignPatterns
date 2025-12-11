using HasAIsA.GoodExample.CarBehaivor;
using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample
{
    public class CarVehicle : Vehicle, ILeftOrRightBehavior
    {
        private ILeftBehavior LeftBehavior { get; set; } = null!;
        private IRightBehavior RightBehavior { get; set; } = null!;

        public CarVehicle()
        {
            ForwardBehavior = new CarForwardBehavior();
            BackwardBehavior = new CarBackwardBehavior();
            LeftBehavior = new CarLeftBehavior();
            RightBehavior = new CarRightBehavior();
        }

        public void ChangeLeftBehavior(ILeftBehavior leftBehavior)
        {
            LeftBehavior = leftBehavior;
        }

        public void ChangeRightBehavior(IRightBehavior rightBehavior)
        {
            RightBehavior = rightBehavior;
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
