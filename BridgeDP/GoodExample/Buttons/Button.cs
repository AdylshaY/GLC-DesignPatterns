using BridgeDP.GoodExample.Buttons.Interfaces;

namespace BridgeDP.GoodExample.Buttons
{
    public class Button(IScreenSize screenSize, IScreenType screenType)
    {
        protected IScreenSize? ScreenSize { get; set; } = screenSize;
        protected IScreenType? ScreenType { get; set; } = screenType;

        public void Initialize(IScreenSize screenSize, IScreenType screenType)
        {
            ScreenSize = screenSize;
            ScreenType = screenType;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Base Draw() Method");
        }

        public void ChangeScreenSize(IScreenSize newScreenSize)
        {
            ScreenSize = newScreenSize;
        }
    }
}
