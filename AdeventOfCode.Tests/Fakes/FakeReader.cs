namespace AdeventOfCode.Tests.Fakes
{
    public class FakeReader : I4ReadingFile
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
}