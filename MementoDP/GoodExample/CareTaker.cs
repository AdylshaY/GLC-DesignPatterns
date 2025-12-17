namespace MementoDP.GoodExample
{
    public class CareTaker(TextEditor textEditor)
    {
        private IMemento? _currentState;
        private readonly Stack<IMemento> _undoStack = new();
        private readonly Stack<IMemento> _redoStack = new();

        public void Backup()
        {
            if (_currentState != null)
            {
                _undoStack.Push(_currentState);
            }
            _currentState = textEditor.Save();
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count == 0)
            {
                throw new InvalidOperationException("No states to undo.");
            }
            
            _redoStack.Push(_currentState!);
            _currentState = _undoStack.Pop();
            textEditor.Restore(_currentState);
        }

        public void Redo()
        {
            if (_redoStack.Count == 0)
            {
                throw new InvalidOperationException("No states to redo.");
            }

            _undoStack.Push(_currentState!);
            _currentState = _redoStack.Pop();
            textEditor.Restore(_currentState);
        }

        public void ShowHistory()
        {
            Console.WriteLine("Current State:");
            if (_currentState is TextEditorMemento current)
            {
                Console.WriteLine($"  {current.GetContext()}");
            }

            Console.WriteLine("\nUndo Stack:");
            foreach (var memento in _undoStack)
            {
                if (memento is TextEditorMemento textEditorMemento)
                {
                    Console.WriteLine($"  {textEditorMemento.GetContext()}");
                }
            }

            Console.WriteLine("\nRedo Stack:");
            foreach (var memento in _redoStack)
            {
                if (memento is TextEditorMemento textEditorMemento)
                {
                    Console.WriteLine($"  {textEditorMemento.GetContext()}");
                }
            }
        }
    }
}
