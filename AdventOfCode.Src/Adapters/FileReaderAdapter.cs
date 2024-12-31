namespace AdeventOfCode.Tests
{
    public class FileReaderAdapter(string inputTxt) : I4ReadingFile
    {
        public IEnumerable<string> ReadFile( )
        {
            return File.ReadLines(inputTxt);
        }
    
        public  IAsyncEnumerable<string> ReadFilAsync( )
        {
            return  File.ReadLinesAsync(inputTxt);
        }
    }
}