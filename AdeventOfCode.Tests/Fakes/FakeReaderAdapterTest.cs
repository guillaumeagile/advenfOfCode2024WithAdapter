using AdeventOfCode.Tests.Fakes;
using FluentAssertions;

namespace AdeventOfCode.Tests;

public class FakeReaderAdapterTest
{
    [Fact]
    public void ReadFileSync()
    {
        var adapter = new FakeReader();
        var actual = adapter.ReadFile();
      //  actual.Should().HaveCount(2);
      var iterator = actual.GetEnumerator();
      iterator.MoveNext().Should().BeTrue();
      iterator.MoveNext().Should().BeTrue();
      iterator.MoveNext().Should().BeFalse();
    }
    
    
    [Fact]
    public async void ReadFileASync()
    {
        var adapter = new FakeReader();
        var actual =  adapter.ReadFilAsync();
       
        var enumerator = actual.GetAsyncEnumerator();
      
       (await enumerator.MoveNextAsync()).Should().BeTrue();
       (await enumerator.MoveNextAsync()).Should().BeTrue();
       (await enumerator.MoveNextAsync()).Should().BeFalse();
       
    }
}