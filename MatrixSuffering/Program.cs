using System;

namespace MatrixSuffering
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split(' ');
            int rolsSize = int.Parse(matrixSize[0]);
            int colsSize = int.Parse(matrixSize[1]);

            string[,] matrix = new string[rolsSize, colsSize];

            for (int row = 0; row < rolsSize; row++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int col = 0; col < colsSize; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] data = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int firstRow = int.Parse(data[1]);
                int firstCol = int.Parse(data[2]);
                int secondRow = int.Parse(data[3]);
                int secondCol = int.Parse(data[4]);

                if (data[0] != "swap" || data.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (firstRow >= matrix.GetLength(0) || secondRow >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (firstCol >= matrix.GetLength(1) || secondCol >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (firstCol < 0 || firstRow < 0 || secondCol < 0 || secondRow < 0)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string firstString = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = firstString;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }



                command = Console.ReadLine();
            }
        }
    }
}
