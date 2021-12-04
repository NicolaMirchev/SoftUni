using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIcTacToe
{
    class fiveByfiveBoard : IBoard
    {
        public fiveByfiveBoard()
        {
            CurrentBoard = new Symbol[5, 5];
        }
        public Symbol[,] CurrentBoard { get; set; }

        public List<Index> GetEmptyPositions()
        {
            List<Index> emptyPositions = new List<Index>();

            for (int row = 0; row < CurrentBoard.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentBoard.GetLength(1); col++)
                {
                    if (CurrentBoard[row, col] == Symbol.None)
                    {
                        emptyPositions.Add(new Index(row, col));
                    }
                }
            }

            return emptyPositions;
        }

        public bool IsTheBoardFull()
        {

            for (int row = 0; row < CurrentBoard.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentBoard.GetLength(1); col++)
                {
                    if (CurrentBoard[row, col] == Symbol.None)
                    {
                        return false;
                    }
                }
            }
            return true;
        }



        public Symbol IsThereMatchingCols()
        {
            for (int col = 0; col < CurrentBoard.GetLength(1); col++)
            {
                Symbol symbolToMatch = CurrentBoard[0, col];

                if (symbolToMatch == Symbol.None) continue;

                for (int row = 1; row < CurrentBoard.GetLength(0); row++)
                {
                    if (CurrentBoard[row, col] == symbolToMatch)
                    {
                        if (row == CurrentBoard.GetLength(0) - 1)
                        {
                            return symbolToMatch;
                        }
                    }
                    else break;
                }
            }

            return Symbol.None;
        }

        public Symbol IsThereMatchingRows()
        {
            for (int row = 0; row < CurrentBoard.GetLength(0); row++)
            {
                Symbol symbolToMatch = CurrentBoard[row, 0];

                if (symbolToMatch == Symbol.None) continue;

                for (int col = 1; col < CurrentBoard.GetLength(1); col++)
                {
                    if (CurrentBoard[row, col] == symbolToMatch)
                    {
                        if (row == CurrentBoard.GetLength(0) - 1)
                        {
                            return symbolToMatch;
                        }
                    }
                    else break;
                }
            }

            return Symbol.None;
        }

        public Symbol IsThereMatchingTLRBDiagonal()
        {
            Symbol symbolToMatch = CurrentBoard[0, 0];

            for (int i = 1; i < CurrentBoard.GetLength(0); i++)
            {
                if (CurrentBoard[i, i] != symbolToMatch)
                {
                    return Symbol.None;
                }
            }

            return symbolToMatch;
        }
        public Symbol ISThereMAtchingBLTRDiagonal()
        {
            Symbol symbolToMatch = CurrentBoard[0, CurrentBoard.GetLength(1) - 1];

            for (int i = 0; i < CurrentBoard.GetLength(1); i++)
            {
                if (CurrentBoard[i, CurrentBoard.GetLength(1) - 1 - i] != symbolToMatch)
                {
                    return Symbol.None;
                }
            }

            return symbolToMatch;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < CurrentBoard.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentBoard.GetLength(1); col++)
                {
                    if (CurrentBoard[row, col] == Symbol.None)
                    {
                        sb.Append(".");
                    }
                    else
                    {
                        sb.Append(CurrentBoard[row, col]);
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public void PlaceSymbol(Index index, Symbol symbol)
        {
            this.CurrentBoard[index.Row, index.Col] = symbol;
        }
    }
}
