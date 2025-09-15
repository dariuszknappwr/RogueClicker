
public class ConsoleInputReader : IInputReader
{
    public InputEvent ReadInput()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        List<String> identifiers = new List<string>
        {
            $"ConsoleKey.{keyInfo.Key}"
        };

        if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
            identifiers.Add("Shift");
        if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
            identifiers.Add("Ctrl");
        if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
            identifiers.Add("Alt");

        return new InputEvent(identifiers);
    }
}