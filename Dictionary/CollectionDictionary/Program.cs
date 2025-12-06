namespace CollectionDictionary;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "jalya");
        dictionary.Add(5, "alina");
        dictionary.Add(3, "aliya");
        dictionary.Add(4, "ayla");

        foreach(var item in dictionary)
        {
            Console.WriteLine(item);
        }
    }
}

