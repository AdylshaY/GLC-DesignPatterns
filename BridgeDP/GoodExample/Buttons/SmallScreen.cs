using BridgeDP.GoodExample.Buttons.Interfaces;

namespace BridgeDP.GoodExample.Buttons
{
    public class SmallScreen : IScreenSize
    {
        public void DrawSize()
        {
            Console.WriteLine("Small Screen Draw() Method");
        }
    }
}
