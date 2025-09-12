
public class KeyBindsSingleton : IKeyBinds
{
    private static KeyBindsSingleton instance;
    private KeyBindsSingleton() { }
    public static KeyBindsSingleton Instance()
    {
        if (instance == null)
        {
            instance = new KeyBindsSingleton();
        }
        return instance;
    }

    public object ClickKey()
    {
        return ConsoleKey.C;
    }

    public object BuyKey()
    {
        return ConsoleKey.D;
    }
}