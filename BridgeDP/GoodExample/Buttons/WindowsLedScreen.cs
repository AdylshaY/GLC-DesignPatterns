using BridgeDP.GoodExample.Buttons.Interfaces;

namespace BridgeDP.GoodExample.Buttons
{
    public class WindowsLedScreen : IScreenType
    {
        public void DrawType()
        {
            Console.WriteLine("Windows LED Screen Draw() Method");
        }
    }
}
