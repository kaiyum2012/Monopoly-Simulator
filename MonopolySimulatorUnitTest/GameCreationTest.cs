using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonopolySimulator;

namespace MonopolySimulatorUnitTest
{
    [TestClass]
    public class GameCreationTest
    {
        [TestMethod]
        public void CheckBoard()
        {
            GameBoard board = GameBoard.Instance;
            GameBoard anotherBoard = GameBoard.Instance;

            Assert.AreEqual(board, anotherBoard);
        }

        //[TestMethod]
        //public void CheckBoardFromDifferentGames()
        //{
        //    MonopolyGame game = new MonopolyGame();
        //    MonopolyGame anotherGame = new MonopolyGame();

        //    Assert.AreNotSame(game.GetGameBoard(), anotherGame.GetGameBoard());
        //}
    }
}
