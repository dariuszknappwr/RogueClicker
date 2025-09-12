public class ConsoleOutputWriter : IOutputWriter
{
    public void Write(string text)
    {
        Console.WriteLine(text);
    }
}