using System;

namespace MonopolySimulator
{
    public class MonopolyGame
    {
        public GameBoard board = null;
        public MonopolyGame()
        {
            // TODO:: Code for Monopoly Game 

            board = GameBoard.Instance;
            //or 
            //board = GameBoard.GetBoard();
        }

        public void PlayGame()
        {
            Console.WriteLine("Game is Stared..... (Simulating ....)");
        }

        public GameBoard GetGameBoard()
        {
            return board;
        }

    }
}