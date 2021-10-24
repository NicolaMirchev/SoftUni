using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFibonaci = int.Parse(Console.ReadLine());

            int result = CalculateNumOfFib(numOfFibonaci);
        }

        private static int CalculateNumOfFib(int numOfFibonaci)
        {
            
            if (numOfFibonaci == 1)
            {
                return 1;
            }

            return CalculateNumOfFib(numOfFibonaci - 1) + CalculateNumOfFib(numOfFibonaci - 2);
        }
    }
}
