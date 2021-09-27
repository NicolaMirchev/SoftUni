using System;

namespace SumMatrixColums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(", ");

            int rows = int.Parse(data[0]);
            int cols = int.Parse(data[1]);

            int[,] matrix = new int[rows, cols];

            for (int rowss = 0; rowss < matrix.GetLength(0); rowss++)
            {
                string[] lineData = Console.ReadLine().Split(" ");


                for (int colls = 0; colls < matrix.GetLength(1); colls++)
                {
                    matrix[rowss, colls] = int.Parse(lineData[colls]);
                }

            }
            for (int i = 0; i < cols; i++)
            {
                int sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
