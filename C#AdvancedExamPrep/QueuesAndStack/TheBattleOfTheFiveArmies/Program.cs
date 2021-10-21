using System;
using System.Collections.Generic;
using System.Linq;

namespace TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[,] map = new char[rows, rows];

            List<int[]> orcs = new List<int[]>();
            int[] armyPosition = new int[2];
            int[] enemyPosition = new int[2];

            for (int row = 0; row < rows; row++)
            {
                string data = Console.ReadLine();
                for (int cols = 0; cols < rows; cols++)
                {

                    if (data[cols] == 'M')
                    {
                        enemyPosition[0] = row;
                        enemyPosition[1] = cols;
                    }
                    else if (data[cols] == 'M')
                    {
                        int[] orc = new int[2] { row, cols };
                        orcs.Add(orc);
                    }
                    else if (data[cols] == 'A')
                    {
                        armyPosition[0] = row; 
                        armyPosition[1] = cols; 
                    }

                    map[row, cols] = data[cols];
                }
            }
            string command = Console.ReadLine();
            while (armor > 0)
            {

                string[] commandArray = command.Split(' ');

                if (commandArray.Length >= 3)
                {
                    int row = int.Parse(commandArray[1]);
                    int col = int.Parse(commandArray[2]);

                    if (row < 0 || row >= map.GetLength(0))
                    {

                    }
                    else if (col < 0  || col >= map.GetLength(1))
                    {

                    }
                    else
                    {
                    map[row, col] = 'O';

                    }
                }

                if (commandArray[0] == "up")
                {
                    if (armyPosition[0] - 1 < 0)
                    {
                        armor--;
                    }
                    else
                    {
                        map[armyPosition[0], armyPosition[1]] = '-';
                        armyPosition[0]--;
                        armor--;
                    }

                }
                else if (commandArray[0] == "down")
                {
                   
                    if (armyPosition[0] + 1 >= map.GetLength(0))
                    {
                        armor--;
                    }
                    else
                    {
                        map[armyPosition[0], armyPosition[1]] = '-';
                        armyPosition[0]--;
                        armor--;
                    }

                }
                else if (commandArray[0] == "left")
                {

                    if (armyPosition[1] - 1 < 0)
                    {
                        armor--;
                    }
                    else
                    {
                        map[armyPosition[0], armyPosition[1]] = '-';
                        armyPosition[1]--;
                        armor--;
                    }


                }
                else if (commandArray[0] == "right")
                {

                    if (armyPosition[1] + 1 >= map.GetLength(1))
                    {
                        armor--;
                    }
                    else
                    {
                        map[armyPosition[0], armyPosition[1]] = '-';
                        armyPosition[1]++;
                        armor--;
                    }



                }

                    int armyrow = armyPosition[0];
                    int armycol = armyPosition[1];

                    if (map[armyrow, armycol] == 'O')
                    {
                        armor -= 2;
                        if (armor <= 0)
                        {
                            map[armyrow, armycol] = 'X';
                            break;
                        }
                        else
                        {
                            map[armyrow, armycol] = '-';
                        }

                    }
                if (enemyPosition[0] == armyPosition[0] && enemyPosition[1] == armyPosition[1])
                {
                    map[enemyPosition[0], enemyPosition[1]] = '-';
                    break;
                }

                command = Console.ReadLine();
            }

            if (map[enemyPosition[0], enemyPosition[1]] == '-')
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
            }
            else
            {
                Console.WriteLine($"The army was defeated at {armyPosition[0]};{armyPosition[1]}.");
            }
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Console.Write(map[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}
