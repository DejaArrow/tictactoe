using System;

namespace tictactoe
{
    class Program
    {
        public static char playerMarker = ' ';
        static int noOfTurns = 0; //Counts number of turns. Once it is equal to 10, it'll end the game and show winner.

        static char[] TTTBoard =
        {
            '1', '2', '3','4', '5', '6','7', '8', '9'
        };
                      
        static void Main(string[] args)
        {
            int player = 2; 
            int input = 0;
            bool inputCorrect = true;

            do //Alternates player turns.
            {
                if (player == 2)
                {
                    player = 1;
                    playerMarker = 'X';
                }
                else if (player == 1)
                {
                    player = 2;
                    playerMarker = 'O';
                }

                Board.DrawBoard();
                noOfTurns++;

                //Check Score.
                WinCheck.HorizontalWin();
                WinCheck.VerticalWin();
                WinCheck.DiagonalWin();
                
                

                if (noOfTurns == 10)
                {
                    WinCheck.Draw();
                }

                do
                {
                    Console.WriteLine($"\nReady Player {0}: It's your move!");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (TTTBoard[0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (TTTBoard[1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (TTTBoard[2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (TTTBoard[3] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (TTTBoard[4] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (TTTBoard[5] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (TTTBoard[6] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (TTTBoard[7] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (TTTBoard[8] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Please try again.");
                        inputCorrect = false;}


                } while (!inputCorrect);
            } while (true);

                  
        }
         public static void XorO(int player, int input)
        {

            if (player == 1) playerMarker = 'X';
            else if (player == 2) playerMarker = 'O';

            switch (input)
            {
                case 1: TTTBoard[0] = playerMarker; break;
                case 2: TTTBoard[1] = playerMarker; break;
                case 3: TTTBoard[2] = playerMarker; break;
                case 4: TTTBoard[3] = playerMarker; break;
                case 5: TTTBoard[4] = playerMarker; break;
                case 6: TTTBoard[5] = playerMarker; break;
                case 7: TTTBoard[6] = playerMarker; break;
                case 8: TTTBoard[7] = playerMarker; break;
                case 9: TTTBoard[8] = playerMarker; break;
            }
           
        }
    }
}
