namespace AdeventOfCode.Tests;

public interface IFileReaderAdapter
{
    IEnumerable<string> ReadFile();
    IAsyncEnumerable<string> ReadFilAsync( );
}