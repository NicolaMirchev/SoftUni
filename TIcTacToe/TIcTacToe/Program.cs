using System;
using TIcTacToe.Players;

namespace TIcTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame newGame = new TicTacToeGame();
            IPlayer firstPlayer = new RandomPlayer(Symbol.X);
            IPlayer secondPlayer = new ConsolePlayer(Symbol.O);

            newGame.Play(new threeXthreeBoard(), firstPlayer, secondPlayer);


        }
    }
}
