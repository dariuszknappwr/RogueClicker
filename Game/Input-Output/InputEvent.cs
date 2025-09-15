public class InputEvent
{
    public HashSet<string> Identifiers { get; }
    public InputEvent(IEnumerable<String> identifiers)
    {
        Identifiers = new HashSet<string>(identifiers);
    }

    public InputEvent(string identifier)
    {
        Identifiers = new HashSet<string>{
            identifier
            };
    }

    public bool Matches(InputEvent other) {
        return Identifiers.SetEquals(other.Identifiers);
    }
}