using AdventOfCode.Port4ProcessingData;
using AdventOfCode.Tests.OutsideIn;

namespace AdventOfCode.Tests.Dummies
{
    /// <summary>
    /// what is called here as Driver is often named as a UserCase
    /// it is a piece of code that Drives everything to perform a task, mainly a processing that is related to the Domain
    /// and that requires data from the outside of the Core Domain
    /// grabbing that data from the outside is the responsibility of the Driven Adapters, and it will be passed inside the Domain
    /// </summary>
    /// <param name="drivenReader"></param>
    public class DummyDriver(I4ExtractingColumns drivenReader) : I4ProcessingData
    {
        public int DayOne()
        {
            return AdventOfCode.Port4ProcessingData.DomainImplementation.GlobalDistance(drivenReader.ExtractTwoColumns());
        }
    }
}