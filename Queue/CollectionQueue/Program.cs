namespace CollectionQueue;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new ();
        queue.Enqueue("anar");
        queue.Enqueue("amir");
        queue.Enqueue("ruslan");
        queue.Enqueue("zulfiqar");

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine("-----");

        foreach(string item in queue)
        {
            Console.WriteLine(item);
        }
    }
}

