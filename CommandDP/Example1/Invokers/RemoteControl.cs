using CommandDP.Example1.Commands;

namespace CommandDP.Example1.Invokers
{
    public class RemoteControl
    {
        private List<ICommand> commandHistory = new();
        private Stack<ICommand> undoStack = new();
        private Queue<ICommand> commandQueue = new();
        private ICommand? currentCommand;

        public void SetCommand(ICommand command)
        {
            currentCommand = command;
        }

        public void PressButton()
        {
            if (currentCommand == null)
            {
                Console.WriteLine("No command set.");
                return;
            }

            commandHistory.Add(currentCommand);
            undoStack.Push(currentCommand);
            currentCommand.Execute();
        }

        public void PressUndo()
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("No commands to undo.");
                return;
            }

            var lastCommand = undoStack.Pop();
            lastCommand.Undo();
        }

        public void AddToQueue(ICommand command)
        {
            commandQueue.Enqueue(command);
            Console.WriteLine($"Added {command.GetType().Name} to queue.");
        }

        public void ExecuteQueue()
        {
            Console.WriteLine($"\nExecuting {commandQueue.Count} commands from queue...");

            while (commandQueue.Count > 0)
            {
                var command = commandQueue.Dequeue();
                SetCommand(command);
                PressButton();
            }

            Console.WriteLine("Queue execution completed.");
        }

        public void ClearQueue()
        {
            commandQueue.Clear();
            Console.WriteLine("Queue cleared.");
        }

        public void ExecuteCommands(params ICommand[] commands)
        {
            foreach (var command in commands)
            {
                SetCommand(command);
                PressButton();
            }
        }

        public void LogHistory()
        {
            Console.WriteLine("\nCommand History:");
            if (commandHistory.Count == 0)
            {
                Console.WriteLine("  (empty)");
                return;
            }

            foreach (var cmd in commandHistory)
            {
                Console.WriteLine($"  - {cmd.GetType().Name}");
            }
        }

        public void LogQueue()
        {
            Console.WriteLine("\nCommand Queue:");
            if (commandQueue.Count == 0)
            {
                Console.WriteLine("  (empty)");
                return;
            }

            foreach (var cmd in commandQueue)
            {
                Console.WriteLine($"  - {cmd.GetType().Name}");
            }
        }
    }
}
