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
            IPlayer secondPlayer = new RandomPlayer(Symbol.O);

            int firstPlayerWins = 0;
            int secondPlayerWins = 0;
            int draws = 0;

            for (int i = 0; i <= 50000; i++)
            {
                var winner = Symbol.None;
                if (i % 2 ==0)
                {
                winner = newGame.Play(new fiveByfiveBoard(), firstPlayer, secondPlayer);
                }
                else
                {
                    winner = newGame.Play(new fiveByfiveBoard(), secondPlayer, firstPlayer);
                }

                   if (winner.ToString() == firstPlayer.CurrentPlayerSymbol.ToString())
                 {
                    firstPlayerWins++;
                 }
                else if (winner.ToString() == secondPlayer.CurrentPlayerSymbol.ToString())
                {
                    secondPlayerWins++;
                }
                else
                {
                    draws++;
                }


            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"First Player wins: {firstPlayerWins}");
            Console.WriteLine($"Second Player wins: {secondPlayerWins}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Draws: " + draws);
        }
    }
}
