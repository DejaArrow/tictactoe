using System;

namespace tictactoe
{   
    abstract class Board
    {
        
    
        public char[] TTTBoard =
            {
            '1', '2', '3','4', '5', '6','7', '8', '9'
            }; //Numbers available for players to select, to place their marker. 

       public static void DrawBoard()

        {
           

           //Draws tic tac toe board on console. 
            {
            Console.Clear();
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", TTTBoard[1], TTTBoard[2], TTTBoard[3]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", TTTBoard[4], TTTBoard[5], TTTBoard[6]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  |   {0}   |   {1}   |   {2}   |", TTTBoard[7], TTTBoard[8], TTTBoard[9]);
            Console.WriteLine("  |       |       |       |");
            Console.WriteLine("  -------------------------");
           

        }
       }

        public static void BoardReset() 
        {
            char[] TTTBoardInitialize =
            {
                '1', '2', '3','4', '5', '6','7', '8', '9'
            };

            TTTBoard = TTTBoardInitialize;
            DrawBoard();
            noOfTurns = 0;
        } 
    }
    
}