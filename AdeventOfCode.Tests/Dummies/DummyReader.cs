namespace AdventOfCode.Tests.OutsideIn
{
    public class DummyReader(IEnumerable<int> list1, IEnumerable<int> list2) : I4ExtractingColumns
    {
        public (IEnumerable<int> l1, IEnumerable<int> l2) ExtractTwoColumns()
        {
            return (list1, list2);
        }
    }
}