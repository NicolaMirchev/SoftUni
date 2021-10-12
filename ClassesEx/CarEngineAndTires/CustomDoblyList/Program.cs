using System;

namespace CustomDoblyList
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var list = new DobbleList();

            list.AddFirst(14);
            list.AddFirst(13);
            list.AddLast(15);

            list.AddLast(100);
            list.AddFirst(0);

            Console.WriteLine(list.RemoveFirts());
            Console.WriteLine(list.RemoveLast());

            foreach (var item in list.ToArray())
            {
                Console.WriteLine("-->" + item);
            }
        }
    }
}
