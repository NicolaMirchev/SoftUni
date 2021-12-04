using Moq;
using NUnit.Framework;
using TIcTacToe;
using TIcTacToe.Players;

namespace TicTacToeGameTests
{
    public class Tests
    {
        private IBoard board;
        [SetUp]
        public void Setup()
        {
            board.CurrentBoard = new Symbol[3, 3];
        }

        [Test]
        public void IndalidInputForIndexThrowsExeption()
        {

        }
    }
}