
public class KeyBindsSingleton : Singleton<KeyBindsSingleton>, IKeyBinds
{

    public string ClickInput { get => "ConsoleKey.C"; }

    public string BuyInput { get => "ConsoleKey.D"; }
}