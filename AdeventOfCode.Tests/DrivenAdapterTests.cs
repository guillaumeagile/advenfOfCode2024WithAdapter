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
        var adapter = new Adapter();
        var actual = adapter.ParseInput(input);
            
        actual.Should().Be( (1, 2));
        actual.Item1.Should().Be(1);
        actual.Item2.Should().Be(2);
     
    }
    
    [Fact]
    public void Test2()
    {
        var input = "2        3";
        var adapter = new Adapter();
        var actual = adapter.ParseInput(input);
            
        actual.Should().Be( (2, 3));
    }
    
}