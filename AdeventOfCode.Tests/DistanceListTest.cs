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
    
    
    [Fact]
    public void GlobalDistanceBetween2Lists()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 3 };
        var actual = GlobalDistance(list1, list2);
        
        actual.Should().Be ( 2);
    }
    
    
    [Fact]
    public void GlobalDistanceBetween2Lists2()
    {
        var list1 = new List<int> { 1, 3 };
        var list2 = new List<int> { 3, 1 };
        var actual = GlobalDistance(list1, list2);
        
        actual.Should().Be ( 0 );
    }
    
    
    [Fact]
    public void SortList()
    {
        var list1 = new List<int> { 3, 1, 2, 4 };
        var actual = list1.SelfSort();
        
        actual.Should().BeEquivalentTo ( new List<int>(){1, 2, 3, 4});
    }
    
    
    [Fact]
    public void GlobalDistanceBetween2ListsBug()
    {
        var list1 = new List<int> { 2, 1 };
        var list2 = new List<int> { 1, 4 };
        var actual = GlobalDistance(list1, list2);
        
        actual.Should().Be ( 2 );
    }

    private int GlobalDistance(List<int> list1, List<int> list2)
    {
        return Distance(list1.SelfSort(), list2.SelfSort()).Sum();
        //.Aggregate((a, b) => a + b);
    }

    private static List<int> Distance(List<int> list1, List<int> list2)
    {
        return list1.Select((value1, index) => DistanceTest.Distance(value1, list2[index])).ToList();
    }
}


static class Extentions
{
    public static List<T> SelfSort<T>(this List<T> list)
    {
        return list.OrderBy(x => x).ToList();
    }
}