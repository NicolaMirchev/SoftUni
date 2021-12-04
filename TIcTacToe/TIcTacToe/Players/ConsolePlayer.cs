using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIcTacToe.Players
{
    class ConsolePlayer : IPlayer
    {

        public ConsolePlayer(Symbol symbol)
        {
            CurrentPlayerSymbol = symbol;
        }
        public Symbol CurrentPlayerSymbol { get ; set ; }

        public Index IndexToPlace(IBoard board)
        {
            Console.WriteLine(board);
            bool validInput = false;
            Index result = new Index();

            while (!validInput)
            {
            try
            {
            int[] index = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
                                  
                    result.Row = index[0];
                    result.Col = index[1];

                    if (result.Col >= board.CurrentBoard.GetLength(1) || result.Col < 0 ||
                        result.Row >= board.CurrentBoard.GetLength(0) || result.Row < 0)
                    {
                        validInput = false;
                    }
                    else validInput = true; 
                                                           
                }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }

            }

            return result;

        }
    }
}
