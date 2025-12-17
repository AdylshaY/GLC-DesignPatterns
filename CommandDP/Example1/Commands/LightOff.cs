using CommandDP.Example1.Receivers;

namespace CommandDP.Example1.Commands
{
    public class LightOff(LightReceiverProcess lightProcess) : ICommand
    {
        public void Execute()
        {
            lightProcess.TurnLightOff();
        }

        public void Undo()
        {
            lightProcess.TurnLightOn();
        }
    }
}
