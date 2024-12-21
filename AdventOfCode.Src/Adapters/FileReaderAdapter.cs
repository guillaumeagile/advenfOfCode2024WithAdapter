namespace AdeventOfCode.Tests;

public class FileReaderAdapter : IFileReaderAdapter
{
    public IEnumerable<string> ReadFile(string inputTxt)
    {
        return File.ReadLines(inputTxt);
    }
    
    public  IAsyncEnumerable<string> ReadFilAsync(string inputTxt)
    {
        return  File.ReadLinesAsync(inputTxt);
    }
}