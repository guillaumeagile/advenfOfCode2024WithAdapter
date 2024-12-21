using AdeventOfCode.Tests.Fakes;
using FluentAssertions;

namespace AdeventOfCode.Tests;

public class FakeReaderAdapterTest
{
    [Fact]
    public void ReadFileSync()
    {
        var adapter = new FakeReader();
        var actual = adapter.ReadFile("");
        actual.Should().HaveCount(2);
    }
    
    
    [Fact]
    public async void ReadFileASync()
    {
        var adapter = new FakeReader();
        var actual =  adapter.ReadFilAsync("");
       
        var enumerator = actual.GetAsyncEnumerator();
        var i = 0;
        while (await enumerator.MoveNextAsync())
        {
            i++;
        }
        i.Should().Be(2);
    }
          
          
}