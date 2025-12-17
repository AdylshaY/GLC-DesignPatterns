using CommandDP.Receivers;

namespace CommandDP.Commands
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
