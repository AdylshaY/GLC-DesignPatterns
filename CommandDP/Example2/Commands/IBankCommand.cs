namespace CommandDP.Example2.Commands
{
    public interface IBankCommand
    {
        void Execute();
        void Undo();
    }
}
