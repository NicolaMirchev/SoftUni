using System;

namespace Knite
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] board = new char[matrixSize, matrixSize];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    char symbol = input[col];
                    board[row, col] = symbol;
                }
            }


            int maxAttacks = 0;
            int removedKnights = 0;
            int knightRow = 0;
            int knightCol = 0;

            while (maxAttacks == 0)
            {
                maxAttacks = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    
                    int currentAttack = 0;

                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (IsValid(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if (IsValid(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if (IsValid(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if (IsValid(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if (IsValid(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currentAttack++;
                        }
                        if (IsValid(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currentAttack++;
                        }
                        if (IsValid(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currentAttack++;
                        }


                        if (currentAttack > maxAttacks)
                        {
                            maxAttacks = currentAttack;
                            knightRow = row;
                            knightCol = col;
                        }


                    }
                }
                if (maxAttacks > 0)
                {
                    board[knightRow, knightCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(removedKnights);
        }
        private static bool IsValid(char[ , ] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }

    }
}
