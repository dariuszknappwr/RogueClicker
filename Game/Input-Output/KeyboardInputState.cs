public class KeyboardInputState : IInputState
{
    public bool IsClick(InputEvent input)
        => input.Identifiers.SetEquals(new[] { KeyBindsSingleton.Instance.ClickInput });

    public bool IsBuy(InputEvent input)
        => input.Identifiers.SetEquals(new[] { KeyBindsSingleton.Instance.BuyInput });

    
}