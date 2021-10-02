using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                names.Add(data);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
