namespace PointsBet_Backend_Online_Code_Test;


/// <summary>
/// Used LINQ and fixed typo.
/// </summary>

public class StringFormatter
{
    private string[] _items;

    public StringFormatter(string[] items)
    {
        _items = items;
    }

    public string ToCommaSeparatedListWithQuote()
    {
        if (_items.Length == 0)
        {
            return string.Empty;
        }
        
        return string.Join(", ", _items.Select(item => $"\"{item}\""));
    }
}
