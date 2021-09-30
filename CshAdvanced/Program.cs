using System;

namespace CshAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int col = 0; col < matrixSize ; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            int firstSum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                firstSum += matrix[i, i];
            }

            int secondSum = 0;

            int counter = matrix.GetLength(1) - 1 ;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                  secondSum += matrix[col, counter];
                counter--;
                }
                
            

            if (firstSum >= secondSum)
            {
                int answer = firstSum - secondSum;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine($"{secondSum - firstSum}");
            }

        }
    }
}
