namespace AreaCalculator.Reader;

public class ConsoleReader : IReader
{
    public string? Read()
    {
        return Console.ReadLine();
    }
}