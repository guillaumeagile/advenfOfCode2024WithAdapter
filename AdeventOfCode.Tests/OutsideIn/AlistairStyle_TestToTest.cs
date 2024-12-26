using FluentAssertions;

namespace AdventOfCode.Tests.OutsideIn;

public class AlistairStyle_TestToTest
{

    [Fact]
    public void Test1()
    {
        var list1 = new List<int> { 2, 1 };
        var list2 = new List<int> { 1, 4 };
        var drivenReader = new DummyReader( list1, list2 );
        var dummyDriver = new DummyDriver( drivenReader);

        var actual = dummyDriver.Execute();
        // pseudo monkey patching
        actual.Should().Be(2);
    }
}

public class DummyDriver
{
    public DummyDriver(DummyReader drivenReader)
    {
        throw new NotImplementedException();
    }

    public int Execute()
    {
        throw new NotImplementedException();
    }
}

public class DummyReader(List<int> list1, List<int> list2) : IListExtractor
{
    public (IEnumerable<int> l1, IEnumerable<int> l2) ExtractTwoColumns()
    {
        throw new NotImplementedException();
    }
}

public interface IListExtractor
{
    (IEnumerable<int> l1, IEnumerable<int> l2) ExtractTwoColumns();
}