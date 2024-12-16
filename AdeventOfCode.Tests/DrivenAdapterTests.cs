using System.Data.Common;
using AdventOfCode.Src;
using FluentAssertions;

namespace AdeventOfCode.Tests;

public class DrivenAdapterTests
{
    [Fact]
    public void Test1()
    {
        var input = "1 2";
        var adapter = new LinesParser();
        var actual = adapter.SingleLine(input);
            
        actual.Should().Be( (1, 2));
        actual.Item1.Should().Be(1);
        actual.Item2.Should().Be(2);
     
    }
    
    [Fact]
    public void Test2()
    {
        var input = "2        3";
        var adapter = new LinesParser();
        var actual = adapter.SingleLine(input);
            
        actual.Should().Be( (2, 3));
    }
    
    [Fact]
    public void Test3()
    {
        var inputs  = new List<string>() { "2        3", "2 4" };
        var adapter = new LinesParser();
        var actual = adapter.MultiLines(inputs);
        var expected = new List<(int, int)>() { (2, 3), (2, 4) };    
        actual.Should().BeEquivalentTo(  expected);
    }
    
}