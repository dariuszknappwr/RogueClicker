
public class ConsoleInputReader : IInputReader
{
    public ConsoleKey ReadKey()
    {
        return Console.ReadKey(true).Key;
    }
}