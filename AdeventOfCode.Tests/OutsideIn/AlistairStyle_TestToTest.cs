using AdventOfCode.Src;
using AdventOfCode.Tests.Dummies;
using FluentAssertions;



namespace AdventOfCode.Tests.OutsideIn
{
    public class AlistairStyle_TestToTest
    {
        [Fact]
        public void DummyDriverDayOneWithSmallInput()
        {
            var list1 = new List<int> { 2, 1 };
            var list2 = new List<int> { 1, 4 };
            var drivenReader = new DummyReader(list1, list2);
            var dummyDriver = new DummyDriver(drivenReader);

            var actual = dummyDriver.DayOne();
         
            actual.Should().Be(2);
        }

        [Fact]
        public void DummyDriverDayOneWithLargerInput()
        {
            var list1 = new List<int> { 3, 4, 2, 1, 3, 3 };
            var list2 = new List<int> { 4, 3, 5, 3, 9, 3 };
            var drivenReader = new DummyReader(list1, list2);
            var dummyDriver = new DummyDriver(drivenReader);

            var actual = dummyDriver.DayOne();
         
            actual.Should().Be(11);
        }
    }
}

namespace AdventOfCode.Port4ProcessingData
{
    
    public interface I4ProcessingData
    {
        int DayOne();
    }
    
    public static class DomainImplementation
    {
        public static int GlobalDistance((IEnumerable<int> l1, IEnumerable<int> l2) twoColumns)
        {
            return CoreDomain.GlobalDistance(twoColumns) ;
        }
    }
}