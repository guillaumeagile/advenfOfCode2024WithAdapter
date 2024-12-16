using AdventOfCode.Src;
using FluentAssertions;

namespace AdeventOfCode.Tests;

public class DistanceListTest
{
    [Fact]
    public void DistanceBetween2Lists()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 2 };
        var actual = CoreDomain. Distance(list1, list2);
        
        actual.Should().BeEquivalentTo ( new List<int>(){1});
    }
    
    
    [Fact]
    public void DistanceBetween2Lists2()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 3 };
        var actual = CoreDomain. Distance(list1, list2);
        
        actual.Should().BeEquivalentTo ( new List<int>(){2});
    }
    
    
    [Fact]
    public void GlobalDistanceBetween2Lists()
    {
        var list1 = new List<int> { 1 };
        var list2 = new List<int> { 3 };
        var actual = CoreDomain. GlobalDistance(list1, list2);
        
        actual.Should().Be ( 2);
    }
    
    
    [Fact]
    public void GlobalDistanceBetween2Lists2()
    {
        var list1 = new List<int> { 1, 3 };
        var list2 = new List<int> { 3, 1 };
        var actual =  CoreDomain. GlobalDistance(list1, list2);
        
        actual.Should().Be ( 0 );
    }
    
    
    [Fact]
    public void GlobalDistanceBetween2ListsBug()
    {
        var list1 = new List<int> { 2, 1 };
        var list2 = new List<int> { 1, 4 };
        var actual = CoreDomain. GlobalDistance(list1, list2);
        
        actual.Should().Be ( 2 );
    }

  

  
}
