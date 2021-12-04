using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIcTacToe.Players
{
    class RandomPlayer : IPlayer
    {
        public RandomPlayer(Symbol symbol)
        {
            CurrentPlayerSymbol = symbol;
        }
        public Symbol CurrentPlayerSymbol { get ; set ; }

        public Index IndexToPlace(IBoard board)
        {
            var emptyPositions = board.GetEmptyPositions();

            Random randomPositionsPicker = new Random();

            int indexToPLay = randomPositionsPicker.Next(0, emptyPositions.Count - 1);
            return emptyPositions[indexToPLay];
        }
    }
}
