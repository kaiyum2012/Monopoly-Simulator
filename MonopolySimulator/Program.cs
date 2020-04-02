using System;

namespace MonopolySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Monopoly Simulator");

            MonopolyGame game = new MonopolyGame();
                      

            game.PlayGame();

            Console.ReadLine();
        }
    }
}
