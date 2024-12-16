namespace AdventOfCode.Src;

public class Adapter
{
    public (int, int) ParseInput(string input)
    {
        var x = input.Split(" ")
            .Where( x => !string.IsNullOrEmpty(x))
            .Select( int.Parse).ToArray();
        return (x[0], x[1]);
    }
}