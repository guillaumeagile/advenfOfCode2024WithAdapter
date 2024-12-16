using FluentAssertions;

namespace AdeventOfCode.Tests;

public class DistanceTest
{
    private int Distance(int value1, int value2)
    {
        return int.Abs(value2 - value1);
    }

    [Fact]
    public void DistanceBetween3And4()
    {
        var actual = Distance(3, 4);
        actual.Should().Be(1);
    }

    [Fact]
    public void DistanceBetween5And7()
    {
        var actual = Distance(5, 7);
        actual.Should().Be(2);
    }
    
    [Fact]
    public void DistanceBetween7and5()
    {
        var actual = Distance(7, 5);
        actual.Should().Be(2);
    }
}