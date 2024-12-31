namespace AdeventOfCode.Tests.Fakes;

public class FakeReader : IFileReaderAdapter
{
    public IEnumerable<string> ReadFile( )
    {
       yield return "2 3";
       yield return "2 4";
    }

    public async IAsyncEnumerable<string> ReadFilAsync( )
    {
         yield return "2 3";
        yield return "2 4"; 
    }
}