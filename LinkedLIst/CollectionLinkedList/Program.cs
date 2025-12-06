namespace CollectionLinkedList;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> nums = new LinkedList<int>();
        nums.AddLast(1);
        nums.AddLast(2);
        nums.AddLast(3);
        nums.AddLast(5);
        nums.AddLast(14);

        foreach(int item in nums)
        {
            Console.WriteLine(item);
        }
        nums.AddFirst(5);
        Console.WriteLine("-------");
        foreach(int items in nums)
        {
            Console.WriteLine(items);
        }
    }
}

