namespace CommandDP.Example1.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

