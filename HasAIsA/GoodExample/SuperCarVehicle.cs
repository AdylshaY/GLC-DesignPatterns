using HasAIsA.GoodExample.CarBehaivor;
using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample
{
    public class SuperCarVehicle : Vehicle, ILeftOrRightBehavior
    {
        protected ILeftBehavior LeftBehavior { get; set; } = null!;
        protected IRightBehavior RightBehavior { get; set; } = null!;

        public SuperCarVehicle()
        {
            BackwardBehavior = new CarBackwardBehavior();
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
