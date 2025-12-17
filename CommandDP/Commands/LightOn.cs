using CommandDP.Receivers;

namespace CommandDP.Commands
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
