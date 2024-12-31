using AdventOfCode.Src;
using FluentAssertions;

namespace AdventOfCode.Tests.OutsideIn;

public class AlistairStyle_TestToTest
{
    [Fact]
    public void Test1()
    {
        var list1 = new List<int> { 2, 1 };
        var list2 = new List<int> { 1, 4 };
        var drivenReader = new DummyReader(list1, list2);
        var dummyDriver = new DummyDriver(drivenReader);

        var actual = dummyDriver.DayOne();
        // pseudo monkey patching
        actual.Should().Be(2);
    }

    [Fact]
    public void Test2()
    {
        var list1 = new List<int> { 3, 4, 2, 1, 3, 3 };
        var list2 = new List<int> { 4, 3, 5, 3, 9, 3 };
        var drivenReader = new DummyReader(list1, list2);
        var dummyDriver = new DummyDriver(drivenReader);

        var actual = dummyDriver.DayOne();
        // pseudo monkey patching
        actual.Should().Be(11);
    }
}

public class DummyDriver(I4ExtractingColumns drivenReader) : I4ProcessingData
{

    public int DayOne()
    {
        return CoreDomain.GlobalDistance( drivenReader.ExtractTwoColumns());
    }
}

public interface I4ProcessingData
{
    int DayOne();
    
}

public class DummyReader( IEnumerable<int> list1, IEnumerable<int> list2) : I4ExtractingColumns
{
    
    public (IEnumerable<int> l1, IEnumerable<int> l2) ExtractTwoColumns()
    {
        return (list1, list2);
    }
}

public interface I4ExtractingColumns
{
    (IEnumerable<int> l1, IEnumerable<int> l2) ExtractTwoColumns();
}