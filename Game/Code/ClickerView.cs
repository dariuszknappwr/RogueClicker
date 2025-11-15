using System;
using System.Reflection.Metadata.Ecma335;
public class ClickerView(ClickController controller, IInputReader reader, IOutputWriter writer) : IClickerView
{
    private readonly ClickController controller = controller;
    private readonly IInputReader inputReader = reader;
    private readonly IOutputWriter outputWriter = writer;

    public string GetClicks()
    {
        return controller.GetClicks().ToString();
    }

    public string GetInfo()
    {
        return
        String.Format(@"C key -> Clicks
        Clicks: {0}
        Clicks per second: {1}"
        , controller.GetClicks().ToString()
        , controller.GetClicksPerSecond().ToString());
    }

    public void Input(InputEvent key)
    {
        controller.HandleInput(key);
    }

    public void Run()
    {
        while (1 != 0)
        {
            System.Console.WriteLine(GetInfo());
            if (!Console.IsInputRedirected)
            {
                InputEvent input = inputReader.ReadInput();
                Input(input);
            }
            Thread.Sleep(1);
        }
    }

    

    
}