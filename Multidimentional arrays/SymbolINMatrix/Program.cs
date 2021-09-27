using System;

namespace SymbolINMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string stringData = Console.ReadLine();
                char[] data = new char[n];

                for (int i = 0; i < stringData.Length; i++)
                {
                    data[i] = stringData[i];
                }

                for (int colls = 0; colls < matrix.GetLength(1); colls++)
                {

                    matrix[rows, colls] = data[colls];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            bool doesOccur = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == symbol)
                    {
                        string coordinats = $"({rows}, {cols})";
                        Console.WriteLine(coordinats);
                        doesOccur = true;
                        break;
                    }

                }
                if (doesOccur)
                {
                    break;
                }
            }
            if (!doesOccur)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

            
        }
    }
}
