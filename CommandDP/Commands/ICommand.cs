namespace CommandDP.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

