using FluentAssertions;

namespace AdeventOfCode.Tests
{
    public class FileReaderAdapterTest
    {
    
        [Fact]
        public void ReadFileSync()
        {
            var adapter = new FileReaderAdapter("input.txt");
            var actual = adapter.ReadFile();
            actual.Should().HaveCount(1000);
        }
    
    
        [Fact]
        public async void ReadFileASync()
        {
            var adapter = new FileReaderAdapter("input.txt");
            var actual =  adapter.ReadFilAsync();
       
            var enumerator = actual.GetAsyncEnumerator();
            var i = 0;
            while (await enumerator.MoveNextAsync())
            {
                i++;
            }
            i.Should().Be(1000);
        }
          
          
    }
}