using System;

namespace SumMatrix
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
                string[] lineData = Console.ReadLine().Split(", ");


                for (int colls = 0; colls < matrix.GetLength(1); colls++)
                {
                    matrix[rowss, colls] = int.Parse(lineData[colls]);
                }

            }

            int maxSum = int.MinValue;
            int startingIndexRows = 0;
            int startingIndexCols = 0;
            for (int rowss = 0; rowss < matrix.GetLength(0) - 1; rowss++)
            {

                for (int colls = 0; colls < matrix.GetLength(1) - 1; colls++)
                {
                    int currentSum = matrix[rowss, colls] + matrix[rowss, colls + 1]
                        + matrix[rowss + 1, colls] + matrix[rowss + 1, colls + 1]; 
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startingIndexRows = rowss;
                        startingIndexCols = colls; 
                    }

                }
            }
            Console.WriteLine(matrix[startingIndexRows, startingIndexCols] + " " 
                +matrix[startingIndexRows, startingIndexCols + 1]);
            Console.WriteLine(matrix[startingIndexRows + 1, startingIndexCols] + " " +
                matrix[startingIndexRows + 1, startingIndexCols + 1]);

            Console.WriteLine(maxSum);
        }
    }
}
