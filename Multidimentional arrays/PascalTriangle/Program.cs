using System;
using System.Numerics;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleLenght = int.Parse(Console.ReadLine());

            Console.WriteLine("1");

           BigInteger[][] triangle = new BigInteger[triangleLenght][];
            triangle[0] = new BigInteger[1] { 1 };
            
            for (int i = 1;  i <= triangleLenght - 1; i++)
            {
                triangle[i] = new BigInteger[i + 1];
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;

                
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {

                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }

            for (int i = 1; i <= triangleLenght - 1; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write($"{triangle[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(triangle[49][6]);
        }
    }
}
