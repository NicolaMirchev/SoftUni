using System;

namespace PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map = new char[8 , 8];
            int[] wPosition = new int[2];
            int[] bPosition = new int[2];

            for (int row = 0; row < map.GetLength(0); row++)
            {

                string input = Console.ReadLine();

                for (int col = 0; col < map.GetLength(0); col++)
                {
                    map[row, col] = input[col];
                    if (input[col] == 'w')
                    {
                        wPosition[0] = row;
                        wPosition[1] = col;
                    }
                    else if (input[col] == 'b')
                    {
                        bPosition[0] = row;
                        bPosition[1] = col;
                    }
                }
            }

            bool wWinner = false;
            bool bWinner = false;

            while (bPosition[0] != 7 || wPosition[0] != 0)
            {
                if (wPosition[1] - 1 >= 0) 
                {

                    if (map[wPosition[0] - 1, wPosition[1] - 1] == 'b' )
                    {
                        Console.WriteLine($"Game over! White capture on {((char)(97 + bPosition[1]))}{8 - bPosition[0]}.");
                        break;
                    }
                }
                if (wPosition[1] + 1 < 8)
                {
                    if (map[wPosition[0] - 1, wPosition[1] + 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {((char)(97 + bPosition[1]))}{8 - bPosition[0]}.");
                        break;
                    }                 
                    else 
                    {
                            wPosition[0]--;
                            map[wPosition[0] + 1, wPosition[1]] = '-';
                            map[wPosition[0], wPosition[1]] = 'w';
                            if (wPosition[0] == 0)
                            {
                                wWinner = true;
                                break;
                            }
                    }
                }
                

                if (bPosition[1] - 1 > 0)
                {
                    if (map[bPosition[0] + 1, bPosition[1] - 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {((char)(97 + wPosition[1]))}{8 - wPosition[0]}.");
                        break;
                    }
                }

                 if (bPosition[1] + 1 < 8)
                {
                    if (map[bPosition[0] + 1, bPosition[1] + 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {((char)(97 + wPosition[1]))}{8 - wPosition[0]}.");
                        break;
                    }
                    else
                    {
                        bPosition[0]++;
                        map[bPosition[0] - 1, bPosition[1]] = '-';
                        map[bPosition[0], bPosition[1]] = 'b';
                        if (bPosition[0] == map.GetLength(0) - 1)
                        {
                            bWinner = true;
                            break;
                        }
                    }
                }
                

            }

            if (wWinner)
            {
                Console.WriteLine($"Game over! White pawn is promoted to a queen at {((char)(97 + wPosition[1]))}8.");
            }
            else if (bWinner)
            {
                Console.WriteLine($"Game over! Black pawn is promoted to a queen at {((char)(97 + bPosition[1]))}1.");
            }

        }
    }
}
