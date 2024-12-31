using AdeventOfCode.Tests;
using AdventOfCode.Tests.Dummies;
using FluentAssertions;

namespace AdventOfCode.Tests.OutsideIn
{
    public class RealToTest
    {
        [Fact]
        public void Test1()
        {
            var adapter = new FileReaderAdapter("small_input.txt" );
        
            var fileExtractor =  new LineToColumnExtractor(adapter);
            // this lineToColumn Extractor needs to be tested on its own
            var dummyDriver = new DummyDriver(fileExtractor);

            var actual = dummyDriver.DayOne();
    
            actual.Should().Be(11);
        }
    }
}