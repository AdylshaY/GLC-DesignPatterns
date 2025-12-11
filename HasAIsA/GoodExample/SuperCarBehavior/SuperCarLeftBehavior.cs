using HasAIsA.GoodExample.Interfaces;

namespace HasAIsA.GoodExample.SuperCarBehavior
{
    public class SuperCarLeftBehavior : ILeftBehavior
    {
        public void Left()
        {
            Console.WriteLine("Super Car Left");
        }
    }
}
