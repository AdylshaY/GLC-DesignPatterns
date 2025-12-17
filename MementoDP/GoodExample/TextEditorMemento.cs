namespace MementoDP.GoodExample
{

    public class TextEditorMemento(string content, int cursorPosition) : IMemento
    {
        private string Content { get; } = content;
        private int CursorPosition { get; } = cursorPosition;

        public DateTime Created { get; } = DateTime.Now;

        public string GetContent() => Content;

        public string GetName() => $"{Created.ToLongDateString()} / ({CursorPosition})";

        public DateTime GetDate() => Created;

        public string GetContext() => Content;

        public int GetCursorPosition() => CursorPosition;
    }
}
