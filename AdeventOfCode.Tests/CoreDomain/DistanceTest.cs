using AdventOfCode.Src;
using FluentAssertions;

namespace AdeventOfCode.Tests
{
    public class DistanceTest
    {
        [Fact]
        public void DistanceBetween3And4()
        {
            var actual = CoreDomain.Distance(3, 4);
            actual.Should().Be(1);
        }

        [Fact]
        public void DistanceBetween5And7()
        {
            var actual = CoreDomain.Distance(5, 7);
            actual.Should().Be(2);
        }

        [Fact]
        public void DistanceBetween7and5()
        {
            var actual = CoreDomain.Distance(7, 5);
            actual.Should().Be(2);
        }
    }
}