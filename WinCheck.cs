using System;

namespace tictactoe
{
    class WinCheck : Board
    {
        public static void HorizontalWin()
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignatue in playerSignatures)
            {
                if (   ((TTTBoard[0] == playerSignatue) && (TTTBoard[1] == playerSignatue) && (TTTBoard[2] == playerSignatue))
                    || ((TTTBoard[3] == playerSignatue) && (TTTBoard[4] == playerSignatue) && (TTTBoard[5] == playerSignatue))
                    || ((TTTBoard[6] == playerSignatue) && (TTTBoard[7] == playerSignatue) && (TTTBoard[8] == playerSignatue)))
                {
                    Console.Clear();
                    if (playerSignatue == 'X')
                    {
                        Console.WriteLine("Congratulations Player 1. You win! ");
                                          
                    }
                    else if (playerSignatue == 'O')
                    {
                       Console.WriteLine("Congratulations Player 2. You win! ");
                    }
                   

                    
                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    Board.BoardReset();

                    break;
                }
            }
        }
         public static void VerticalWin()
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignatue in playerSignatures)
            {
                if (   ((TTTBoard[0] == playerSignatue) && (TTTBoard[3] == playerSignatue) && (TTTBoard[6] == playerSignatue))
                    || ((TTTBoard[1] == playerSignatue) && (TTTBoard[4] == playerSignatue) && (TTTBoard[7] == playerSignatue))
                    || ((TTTBoard[2] == playerSignatue) && (TTTBoard[5] == playerSignatue) && (TTTBoard[8] == playerSignatue)))
                {
                     Console.Clear();
                    if (playerSignatue == 'X')
                    {
                        Console.WriteLine("Congratulations Player 1. You win! ");
                                          
                    }
                    else if (playerSignatue == 'O')
                    {
                       Console.WriteLine("Congratulations Player 2. You win! ");
                    }

                    
                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    Board.BoardReset();

                    break;
                }
            }
        } 

        public static void DiagonalWin()
        {
            char[] playerSignatures = { 'X', 'O' };

            foreach (char playerSignatue in playerSignatures)
            {
                if (   ((TTTBoard[0] == playerSignatue) && (TTTBoard[4] == playerSignatue) && (TTTBoard[8] == playerSignatue))
                    || ((TTTBoard[6] == playerSignatue) && (TTTBoard[4] == playerSignatue) && (TTTBoard[2] == playerSignatue)))
                {
                    Console.Clear();
                    if (playerSignatue == 'X')
                    {
                        Console.WriteLine("Congratulations Player 1. You win! ");
                                          
                    }
                    else if (playerSignatue == 'O')
                    {
                       Console.WriteLine("Congratulations Player 2. You win! ");
                    }

                   
                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    Board.BoardReset();

                    break;
                }
            }
        } 

        public static void Draw()
        {
            
            {
                Console.WriteLine("Tie!" +
                                  "\nPlease press any key to reset the game and try again!");
                Console.ReadKey();
                Board.BoardReset();
                
            }
        }
    }
}