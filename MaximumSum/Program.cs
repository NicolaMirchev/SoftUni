using System;

namespace MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split(' ');
            int rolsSize = int.Parse(matrixSize[0]);
            int colsSize = int.Parse(matrixSize[1]);

            int[,] matrix = new int[rolsSize, colsSize];

            for (int row = 0; row < rolsSize; row++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int col = 0; col < colsSize; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            int maxSum = int.MinValue;

            int[ , ] winnerSubmatrix = new int[ 3, 3];
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {


                for (int col = 0; col < matrix.GetLength(1) - 2 ; col++)
                {
                    
                    int currentSum = 0;
                    int[,] insideMatrix = new int[3, 3];
                    for (int insiderow = 0; insiderow < 3; insiderow++)
                    {

                        for (int insidecol = 0; insidecol < 3; insidecol++)
                        {
                            insideMatrix[insiderow, insidecol] = matrix[row + insiderow, col + insidecol];
                            currentSum += insideMatrix[insiderow, insidecol];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        winnerSubmatrix = insideMatrix;
                    }

                }                
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < winnerSubmatrix.GetLength(0); row++)
            {
                for (int col = 0; col < winnerSubmatrix.GetLength(1); col++)
                {

                    Console.Write($"{winnerSubmatrix[row, col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
