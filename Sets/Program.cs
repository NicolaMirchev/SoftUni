using System;
using System.Collections.Generic;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            HashSet<string> setOfNames = new HashSet<string>();

            for (int i = 0; i < lines; i++)
            {

                string name = Console.ReadLine();
                setOfNames.Add(name);

            }
            foreach (var item in setOfNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
