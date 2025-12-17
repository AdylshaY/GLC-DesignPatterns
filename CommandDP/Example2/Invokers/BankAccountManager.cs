using CommandDP.Example2.Commands;

namespace CommandDP.Example2.Invokers
{
    public class BankAccountManager
    {
        private readonly List<IBankCommand> _commandHistory = [];
        private readonly Stack<IBankCommand> _undoStack = [];

        public void ExecuteCommand(IBankCommand command)
        {
            command.Execute();
            _commandHistory.Add(command);
        }

        public void UndoLastCommand()
        {
            if (_commandHistory.Count == 0)
            {
                throw new InvalidOperationException("No commands to undo.");
            }
            var lastCommand = _commandHistory[^1];
            lastCommand.Undo();
            _commandHistory.RemoveAt(_commandHistory.Count - 1);
            _undoStack.Push(lastCommand);
        }

        public void RedoLastCommand()
        {
            if (_undoStack.Count == 0)
            {
                throw new InvalidOperationException("No commands to redo.");
            }
            var commandToRedo = _undoStack.Pop();
            commandToRedo.Execute();
            _commandHistory.Add(commandToRedo);
        }
    }
}
