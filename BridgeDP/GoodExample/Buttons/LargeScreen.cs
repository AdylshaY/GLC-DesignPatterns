using BridgeDP.GoodExample.Buttons.Interfaces;

namespace BridgeDP.GoodExample.Buttons
{
    public class LargeScreen : IScreenSize
    {
        public void DrawSize()
        {
            Console.WriteLine("Large Screen Draw() Method");
        }
    }
}
