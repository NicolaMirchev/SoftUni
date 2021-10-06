using System;
using System.Linq;

namespace TriFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();


            Func<string, int, bool> firstFunc = (word, number) => word.Sum(x => x) >= number;

            Func<string[],Func<string, int, bool>,string> secondFunc = (list, secondFunc) => list.FirstOrDefault((x) => secondFunc(x, N));

            Console.WriteLine(secondFunc(names, firstFunc));
        }
    }
}
