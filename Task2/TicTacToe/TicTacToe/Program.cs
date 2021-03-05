using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGame = true;
            char player = 'X';
            char[,] playBoard = new char[3, 3];
            int playerMoves = 0;

            while(isGame)
            {
                Start:
                Console.Clear();

                PrintBoard(playBoard);

                Console.Write("Enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter colum: ");
                int colum = Convert.ToInt32(Console.ReadLine());                
                
                if(playBoard[row,colum] == 'X' || playBoard[row, colum] == 'O')
                {
                    Console.WriteLine("Cell isn`t empty");
                    goto Start;
                }

                playBoard[row, colum] = player;

                //Example for check a winner
                if (player == playBoard[0, 0] && player == playBoard[0, 1] && player == playBoard[0,2])
                {
                    Console.WriteLine(player + " Won!");
                    isGame = false;
                }

                playerMoves = playerMoves + 1;
                //Example for check a drow
                if(playerMoves == 9)
                {
                    Console.WriteLine("DRAW");
                    isGame = false;
                }

                player = ChangeTurn(player);
            }
           
        }


        static char ChangeTurn(char currentPlayer)
        {

            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }

        static void PrintBoard(char [,] playBoard)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int colum = 0; colum < 3; colum++)
                {
                    Console.Write(playBoard[row, colum]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
