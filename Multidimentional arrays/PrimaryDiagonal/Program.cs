using System;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int colls = 0; colls < matrix.GetLength(1); colls++)
                {

                    matrix[rows, colls] = int.Parse(data[colls]);
                }
            }
            int sum = 0;
            for (int number = 0; number < matrix.GetLength(0); number++)
            {

                sum += matrix[number, number];
            }
            Console.WriteLine(sum);
        }
    }
}
