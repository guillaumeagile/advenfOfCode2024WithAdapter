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
    
    
    [Fact]
    public void DistanceBetween2Lists2()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 3 };
        var actual = Distance(list1, list2);
        
        actual.Should().BeEquivalentTo ( new List<int>(){2});
    }

    private static List<int> Distance(List<int> list1, List<int> list2)
    {
        var result = new List<int>();
        for (var i = 0; i < list1.Count; i++)
        {
            result.Add(DistanceTest. Distance(list1[i], list2[i]));
        } 

        return result;
    }
}