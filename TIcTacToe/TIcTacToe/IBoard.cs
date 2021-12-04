using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIcTacToe
{
    interface IBoard
    {
        
        Symbol[,] CurrentBoard{ get; set; }

        public bool IsTheBoardFull();
        public List<Index> GetEmptyPositions();

        public Symbol IsThereMatchingRows();

        public Symbol IsThereMatchingCols();
        public Symbol IsThereMatchingTLRBDiagonal();
        public Symbol ISThereMAtchingBLTRDiagonal();

        public void PlaceSymbol(Index index, Symbol symbol);
    
    }
}
