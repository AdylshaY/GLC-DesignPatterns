namespace MementoDP.BadExample
{
    public class TextEditor
    {
        public string Content { get; set; } = string.Empty;
        public int CursorPosition { get; set; }

        public void Write(string text)
        {
            Content = Content.Insert(CursorPosition, text);
            CursorPosition += text.Length;
        }

        public TextEditorState Save()
        {
            return new TextEditorState
            {
                Content = this.Content,
                CursorPosition = this.CursorPosition
            };
        }

        public void Restore(TextEditorState state)
        {
            this.Content = state.Content;
            this.CursorPosition = state.CursorPosition;
        }

        public void WriteToConsole()
        {
            Console.WriteLine(Content);
            Console.WriteLine(new string(' ', CursorPosition) + '^');
        }
    }
}
