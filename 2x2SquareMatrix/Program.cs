using System;

namespace _2x2SquareMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split(' ');
            int rolsSize = int.Parse(matrixSize[0]);
            int colsSize = int.Parse(matrixSize[1]);

            char[,] matrix = new char[rolsSize, colsSize];

            for (int row = 0; row < rolsSize; row++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int col = 0; col < colsSize; col++)
                {
                    matrix[row, col] = char.Parse(input[col]);
                }
            }
            int counter = 0;

            for (int rols = 0; rols < matrix.GetLength(0) - 1; rols++)
            {

                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    char currentChar = matrix[rols, cols];
                    if (currentChar == matrix[rols, cols + 1])
                       
                    {
                        if (currentChar == matrix[rols + 1, cols])
                        {
                        if ( currentChar == matrix[rols + 1, cols + 1]);
                        {
                            counter++;
                        }

                        }
                        
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
