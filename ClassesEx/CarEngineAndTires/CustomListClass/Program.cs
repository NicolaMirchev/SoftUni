using System;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListClass();

            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(15);
            list.Add(16);

            list.RemoveAt(4);

            var booll = list.Contains(16);
            list.Swap(0, list.Indexer);
            Console.WriteLine(list.Count);
        }
    }
}
