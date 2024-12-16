namespace AdventOfCode.Src;

public class CoreDomain
{
    public static int Distance(int value1, int value2)
    {
        return int.Abs(value2 - value1);
    }
    
    public static List<int> Distance(List<int> list1, List<int> list2)
    {
        return list1.Select((value1, index) => CoreDomain.Distance(value1, list2[index])).ToList();
    }
    
    public static int GlobalDistance(List<int> list1, List<int> list2)
    {
        return Distance(list1.SelfSort(), list2.SelfSort()).Sum();
        //.Aggregate((a, b) => a + b);
    }
}



static class Extentions
{
    public static List<T> SelfSort<T>(this List<T> list)
    {
        return list.OrderBy(x => x).ToList();
    }
}