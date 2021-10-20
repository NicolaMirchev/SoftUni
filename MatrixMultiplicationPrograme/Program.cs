using System;
using System.Linq;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first matrix rows & colums!");
            int[] firstMRowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Enter second matrix rows & colums!");
            int[] secondMRowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (firstMRowsAndCols[1] == secondMRowsAndCols[0])
            {
                int[,] firstMatrix = new int[firstMRowsAndCols[0], firstMRowsAndCols[1]];
                int[,] secondMatrix = new int[secondMRowsAndCols[0], secondMRowsAndCols[1]];


                for (int rows = 0; rows < firstMatrix.GetLength(0); rows++)
                {

                    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int cols = 0; cols < firstMatrix.GetLength(1); cols++)
                    {
                        firstMatrix[rows, cols] = numbers[cols];
                    }

                }

                for (int rows = 0; rows < secondMatrix.GetLength(0); rows++)
                {

                    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int cols = 0; cols < secondMatrix.GetLength(1); cols++)
                    {
                        secondMatrix[rows, cols] = numbers[cols];
                    }

                }

                int[,] finalMatrix = new int[firstMRowsAndCols[0], secondMRowsAndCols[1]];

                for (int colsOfSecondM = 0; colsOfSecondM < secondMatrix.GetLength(1); colsOfSecondM++)
                {
                    for (int rows = 0; rows < firstMatrix.GetLength(0); rows++)
                    {
                        int currentNumber = 0;
                        for (int i = 0; i < firstMatrix.GetLength(1); i++)
                        {
                            currentNumber += firstMatrix[rows , i] * secondMatrix[i , colsOfSecondM];
                        }

                        finalMatrix[rows, colsOfSecondM] = currentNumber;
                    }


                }
                for (int row = 0; row < finalMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < finalMatrix.GetLength(1); col++)
                    {
                        Console.Write($"{finalMatrix[row, col]} ");
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Multiplication cannot be done.");
            }

        }
    }
}
