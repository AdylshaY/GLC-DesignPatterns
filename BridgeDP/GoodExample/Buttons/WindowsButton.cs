using BridgeDP.GoodExample.Buttons.Interfaces;

namespace BridgeDP.GoodExample.Buttons
{
    public class WindowsButton(IScreenSize screenSize, IScreenType screenType) : Button(screenSize, screenType)
    {
        public override void Draw()
        {
            ScreenSize?.DrawSize();
            ScreenType?.DrawType();
            Console.WriteLine("Windows Button Draw() Method");
        }
    }
}
