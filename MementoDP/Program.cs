using MementoDP.GoodExample;

var textEditor = new TextEditor();
var caretaker = new CareTaker(textEditor);

textEditor.Write("Hello, ");
caretaker.Backup();
textEditor.WriteToConsole();

textEditor.Write("world!");
caretaker.Backup();
textEditor.WriteToConsole();

textEditor.Write(" How are you?");
caretaker.Backup();
textEditor.WriteToConsole();

Console.WriteLine("\n--- UNDO ---");
caretaker.Undo();
textEditor.WriteToConsole();

Console.WriteLine("\n--- UNDO ---");
caretaker.Undo();
textEditor.WriteToConsole();

Console.WriteLine("\n--- REDO ---");
caretaker.Redo();
textEditor.WriteToConsole();

Console.WriteLine("\n--- History ---");
caretaker.ShowHistory();
