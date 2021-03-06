using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIcTacToe.Players
{
    interface IPlayer 
    {
        Symbol CurrentPlayerSymbol { get; set; }
        public Index IndexToPlace(IBoard board); 
    }
}
