namespace AdeventOfCode.Tests
{
    public interface I4ReadingFile
    {
        IEnumerable<string> ReadFile();
        IAsyncEnumerable<string> ReadFilAsync( );
    }
}