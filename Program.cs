// See https://aka.ms/new-console-template for more information

using PointsBet_Backend_Online_Code_Test;

class Program
{
    static void Main()
    {
        string[] items = { "a", "b", "c" };


        StringFormatter formatter = new StringFormatter(items);

        string result = formatter.ToCommaSeparatedListWithQuote();
        Console.WriteLine(result);

    }
}
