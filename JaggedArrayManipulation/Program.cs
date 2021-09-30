using System;

namespace JaggedArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            long[][] matrix = new long[lenght][];

            for (int row = 0; row < lenght; row++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                matrix[row] = new long[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = int.Parse(input[col]);
                }

            }
            for (int row = 0; row < matrix.Length - 1; row++)
            {

                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }

            }


            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] data = command.Split(' ',StringSplitOptions.RemoveEmptyEntries) ;
                int row = int.Parse(data[1]);
                int col = int.Parse(data[2]);
                int value = int.Parse(data[3]);

                if (row < 0 || row >= matrix.Length)
                {

                }
                else if (col < 0 || col >= matrix[row].Length)
                {

                }
                else
                {
                    if (data[0].ToLower() == "add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (data[0].ToLower() == "subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }



                command = Console.ReadLine();
            }

            foreach (var line in matrix)
            {
                Console.WriteLine(string.Join(' ', line));
            }
        }
    }
}
