using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Vloggers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputstring = Console.ReadLine().Split(", ").ToArray();
            int[] input = inputstring.Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", " , input.Where(n => n % 2 == 0).OrderBy(n => n)));
            
        }
    }
}
