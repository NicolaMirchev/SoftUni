using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIcTacToe.Players;

namespace TIcTacToe
{
    class TicTacToeGame
    {

        public Symbol Play(IBoard board, IPlayer player1, IPlayer player2)
        {

            player1.CurrentPlayerSymbol = Symbol.X;
            player2.CurrentPlayerSymbol = Symbol.O;
            IPlayer currentPlayer = player1;


            while (true)
            {
                if (GetWinner(board) != Symbol.None)
                {

                    return GetWinner(board);
                }
                else if (board.IsTheBoardFull())
                {
                    return GetWinner(board);
                }
                else
                {
                    if (currentPlayer == player1)
                    {
                    currentPlayer.PlaceSymbol(board, currentPlayer.CurrentPlayerSymbol);
                        currentPlayer = player2;
                    }
                    else
                    {
                        currentPlayer.PlaceSymbol(board, currentPlayer.CurrentPlayerSymbol);
                        currentPlayer = player1;
                    }
                }
               

                



            }            
        }
        public Symbol GetWinner(IBoard board) 
        {
            if (board.ISThereMAtchingBLTRDiagonal() != Symbol.None )
            {
                return board.ISThereMAtchingBLTRDiagonal();
            }
            else if (board.IsThereMatchingTLRBDiagonal() != Symbol.None)
            {
                return board.IsThereMatchingTLRBDiagonal();
            }
            else if (board.IsThereMatchingRows() != Symbol.None)
            {
                return board.IsThereMatchingRows();
            }
            else if (board.IsThereMatchingCols() != Symbol.None)
            {
                return board.IsThereMatchingCols();
            }

            return Symbol.None;
        }
    }
}
