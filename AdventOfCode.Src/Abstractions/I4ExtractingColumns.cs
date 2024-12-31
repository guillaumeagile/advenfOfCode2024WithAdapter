namespace AdventOfCode.Tests.OutsideIn
{
    public interface I4ExtractingColumns
    {
        (IEnumerable<int> l1, IEnumerable<int> l2) ExtractTwoColumns();
    }
}