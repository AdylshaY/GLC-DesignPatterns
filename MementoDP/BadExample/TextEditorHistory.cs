namespace MementoDP.BadExample
{
    public class TextEditorHistory
    {
        private readonly Stack<TextEditorState> _history = new();
        private TextEditorState? _currentState;

        public void Save(TextEditorState state)
        {
            if (_currentState != null)
            {
                _history.Push(_currentState);
            }
            _currentState = state;
        }

        public TextEditorState Undo()
        {
            if (_history.Count == 0)
            {
                throw new InvalidOperationException("No states to undo.");
            }
            _currentState = _history.Pop();
            return _currentState;
        }
    }
}
