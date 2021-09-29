using System;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split(' ');
            int rolsSize = int.Parse(matrixSize[0]);
            int colsSize = int.Parse(matrixSize[1]);

            char[,] matrix = new char[rolsSize, colsSize];

            string word = Console.ReadLine();
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                

                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                      
                        matrix[row, col] = (char)word[counter];
                        if (counter == word.Length - 1)
                        {
                            counter = 0;
                        }
                        else
                        {
                            counter++;
                        }
                        
                    }

                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = (char)word[counter];
                        if (counter == word.Length - 1)
                        {
                            counter = 0;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                } 
                
                
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine( );
            }
        }
    }
}
