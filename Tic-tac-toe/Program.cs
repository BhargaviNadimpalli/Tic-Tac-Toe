using System;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe progrmas");

            TicTacToeGame game = new TicTacToeGame();
            game.InitializingBoard();
        }
    }
}
