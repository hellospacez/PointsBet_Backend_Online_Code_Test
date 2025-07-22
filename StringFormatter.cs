namespace PointsBet_Backend_Online_Code_Test;


/// <summary>
/// Used LINQ and fixed typo.
/// </summary>

public class StringFormatter
{
    private string[] _items;
    private string _quote;

    public StringFormatter(string[] items, string quote)
    {
        _items = items;
        _quote = quote;
    }

    public string ToCommaSeparatedList()
    {
        if (_items.Length == 0)
        {
            return string.Empty;
        }

        return string.Join(", ", _items.Select(item => $"{_quote}{item}{_quote}"));
    }
}