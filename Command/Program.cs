using Command;

internal class Program
{
    private static void Main(string[] args)
    {
        var textEditor = new TextEditor();
        var commandHistory = new CommandHistory();

        var insertCommand1 = new InsertTextCommand(textEditor, "Hello");
        insertCommand1.Execute();
        commandHistory.Add(insertCommand1);

        var insertCommand2 = new InsertTextCommand(textEditor, " World");
        insertCommand2.Execute();
        commandHistory.Add(insertCommand2);

        var deleteCommand = new DeleteTextCommand(textEditor, " World");
        deleteCommand.Execute();
        commandHistory.Add(deleteCommand);

        if (commandHistory.hasCommand())
        {
            var lastCommand = commandHistory.Undo();
            lastCommand.Undo();
        }

        Console.WriteLine($"Final text: {textEditor.GetText()}");
    }
}