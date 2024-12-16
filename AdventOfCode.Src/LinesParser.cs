namespace AdventOfCode.Src;

public class LinesParser
{
    public (int, int) SingleLine(string input)
    {
        var x = input.Split(" ")
            .Where( x => !string.IsNullOrEmpty(x))
            .Select( int.Parse).ToArray();
        return (x[0], x[1]);
    }

    public IEnumerable<(int, int)> MultiLines(IEnumerable<string> inputs)
    {
         return   new List<(int, int)>() { (2, 3), (0, 4) };
    }
   
    
    //TODO: essayer avec une version Observable Rx (Reactive Extensions) in C#
    
    // TODO: essayer une version avec des Stream
    
}