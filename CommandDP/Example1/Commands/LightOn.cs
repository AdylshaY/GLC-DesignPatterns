using CommandDP.Example1.Receivers;

namespace CommandDP.Example1.Commands
{
    public class LightOn(LightReceiverProcess lightProcess) : ICommand
    {
        public void Execute()
        {
            lightProcess.TurnLightOn();
        }

        public void Undo()
        {
            lightProcess.TurnLightOff();
        }
    }
}
