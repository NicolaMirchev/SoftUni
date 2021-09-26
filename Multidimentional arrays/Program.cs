using System;

namespace Multidimentional_arrays
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
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
