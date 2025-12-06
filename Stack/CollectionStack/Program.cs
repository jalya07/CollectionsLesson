namespace CollectionStack;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack = new();
        stack.Push("baki ");
        stack.Push("naxcivan");
        stack.Push("lenkaran");
        stack.Push("shusha");
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        string str;
        Console.WriteLine(stack.TryPop(out str));
        Console.WriteLine(str);
        Console.WriteLine("----------");
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }
    }
}

