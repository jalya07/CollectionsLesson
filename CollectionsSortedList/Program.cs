using System.Collections;

namespace CollectionsSortedList;

class Program
{
    static void Main(string[] args)
    {
        SortedList sorted = new SortedList();
        sorted.Add(1, "lalla");
        sorted.Add(3, "aliya");
        sorted.Add(2, "ayla");
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }



        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(1, "jalya");
        sortedList.Add(3, "ali");
        sortedList.Add(2, "alm");

        bool result = sortedList.TryAdd(1, "lorem");
        Console.WriteLine(result);
        Console.WriteLine("----------");
        foreach (var item in sortedList)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }



    }
}

