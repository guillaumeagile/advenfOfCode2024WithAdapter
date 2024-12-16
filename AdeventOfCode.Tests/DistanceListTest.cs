using FluentAssertions;

namespace AdeventOfCode.Tests;

public class DistanceListTest
{
    [Fact]
    public void DistanceBetween2Lists()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 2 };
        var actual = Distance(list1, list2);
        
        actual.Should().BeEquivalentTo ( new List<int>(){1});
    }

    private List<int> Distance(List<int> list1, List<int> list2)
    {
      return new List<int>() { 1};
    }
}