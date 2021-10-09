using System;

namespace Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');

            foreach (var name in names)
            {
                Console.WriteLine("Sir " + name);
            }
        }
    }
}
