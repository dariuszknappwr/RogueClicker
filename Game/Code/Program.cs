// See https://aka.ms/new-console-template for more information
ClickModel model = new();
ClickController controller = new(model);
IInputReader reader = new ConsoleInputReader();
IOutputWriter writer = new ConsoleOutputWriter();
ClickerView view = new(controller, reader, writer);
view.Run();
