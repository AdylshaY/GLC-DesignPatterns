namespace MementoDP.GoodExample
{
    public class TextEditor
    {
        private string _content = string.Empty;
        private int _cursorPosition;

        public void Write(string text)
        {
            _content = _content.Insert(_cursorPosition, text);
            _cursorPosition += text.Length;
        }

        public void WriteToConsole()
        {
            Console.WriteLine($"Content: {_content}, CursorPosition: {_cursorPosition}");
        }

        public IMemento Save()
        {
            return new TextEditorMemento(_content, _cursorPosition);
        }

        public void Restore(IMemento memento)
        {
            if (memento is TextEditorMemento textEditorMemento)
            {
                _content = textEditorMemento.GetContent();
                _cursorPosition = textEditorMemento.GetCursorPosition();
            }
            else
            {
                throw new ArgumentException("Invalid memento type");
            }
        }
    }
}
