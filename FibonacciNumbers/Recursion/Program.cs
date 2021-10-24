using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long result = Factoriel(number);

            Console.WriteLine(result);
        }

        private static long Factoriel(long number)
        {
            long index = number;
            if (index == 1)
            {
                return 1;
            }

            return index *= Factoriel(index - 1);
        }
    }
}
