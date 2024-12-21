namespace AdeventOfCode.Tests;

public interface IFileReaderAdapter
{
    IEnumerable<string> ReadFile(string inputTxt);
    IAsyncEnumerable<string> ReadFilAsync(string inputTxt);
}