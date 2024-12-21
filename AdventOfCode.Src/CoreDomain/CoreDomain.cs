namespace AdventOfCode.Src;

public class CoreDomain
{
    public static int Distance(int value1, int value2)
    {
        return int.Abs(value2 - value1);
    }

    public static List<int> Distance(IEnumerable<int> list1, IEnumerable<int> list2)
    {
        return list1.Select((value1, index) => Distance(value1, list2.ElementAt(index))).ToList();
    }

    public static int GlobalDistance(IEnumerable<int> list1, IEnumerable<int> list2)
    {
        return Distance(list1.SelfSort(), list2.SelfSort()).Sum();
        //.Aggregate((a, b) => a + b);
    }
}

internal static class Extentions
{
    public static List<T> SelfSort<T>(this IEnumerable<T> list)
    {
        return list.OrderBy(x => x).ToList();
    }
}