// See https://aka.ms/new-console-template for more information

using PointsBet_Backend_Online_Code_Test;

class Program
{
    static void Main()
    {
        string[] items = { "apple", "banana", "cherry" };
        string quote = "\"";

        StringFormatter formatter = new StringFormatter(items, quote);

        string result = formatter.ToCommaSeparatedList();
        Console.WriteLine(result);

    }
}