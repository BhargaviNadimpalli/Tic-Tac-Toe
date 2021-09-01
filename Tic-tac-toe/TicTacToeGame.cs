using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_tac_toe
{
    public class TicTacToeGame
    {
        public void InitializingBoard()
        {
            char[] board = new char[10];
            

            for (int i = 1; i < 10; i++)
                board[i] = ' ';

        }
    }
}
