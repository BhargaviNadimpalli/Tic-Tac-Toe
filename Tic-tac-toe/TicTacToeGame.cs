using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_tac_toe
{
    class TicTacToeGame
    {
        public char player { get; set; }
        public char computer { get; set; }
        public void InitializingBoard()
        {
            char[] board = new char[10];


            for (int i = 1; i < 10; i++)
                board[i] = ' ';

        }
        public void ChooseOption()
        {
            Console.Write("Choose X or O : ");
            
            char input = char.Parse(Console.ReadLine());
            //if player selects O
            if (input == 'X')
            {

                computer = 'O';
                Console.WriteLine("Computer"+computer);
            }
            //if player selects X
            else if (input == 'O')
            {
                computer = 'X';
                Console.WriteLine("Computer"+ computer);
            }
            else
            {
                Console.WriteLine("Invalid letter");
            }
        }
    }
}

