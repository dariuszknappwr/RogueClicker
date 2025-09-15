public class InputStateMachine : Singleton<InputStateMachine>
{
    private IInputState _currentState;

    public InputStateMachine()
    {
        IInputState startupState = new KeyboardInputState();
        _currentState = startupState;
    }

    public InputStateMachine(IInputState initialState)
    {
        _currentState = initialState;
    }

    public void SetState(IInputState newState)
    {
        _currentState = newState;
    }

    public bool IsBuy(InputEvent input) => _currentState.IsBuy(input);
    public bool IsClick(InputEvent input) => _currentState.IsClick(input);
}