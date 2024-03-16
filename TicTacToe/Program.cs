using System;

namespace TicTacToe
{
    public class Program
    {
        static char[,] playersField =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        private static int turn = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterSymbol(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterSymbol(player, input);
                }

                SetField();

                char[] playerChar = { 'X', 'O' };

                foreach (char playerChars in playerChar)
                {
                    if (((playersField[0, 0] == playerChars) && (playersField[0, 1] == playerChars) && (playersField[0, 2] == playerChars)) ||
                        ((playersField[1, 0] == playerChars) && (playersField[1, 1] == playerChars) && (playersField[1, 2] == playerChars)) ||
                        ((playersField[2, 0] == playerChars) && (playersField[2, 1] == playerChars) && (playersField[2, 2] == playerChars)) ||
                        ((playersField[0, 0] == playerChars) && (playersField[1, 0] == playerChars) && (playersField[2, 0] == playerChars)) ||
                        ((playersField[1, 0] == playerChars) && (playersField[1, 1] == playerChars) && (playersField[1, 2] == playerChars)) ||
                        ((playersField[0, 2] == playerChars) && (playersField[1, 2] == playerChars) && (playersField[2, 2] == playerChars)) ||
                        ((playersField[0, 0] == playerChars) && (playersField[1, 1] == playerChars) && (playersField[2, 2] == playerChars)) ||
                        ((playersField[0, 2] == playerChars) && (playersField[1, 1] == playerChars) && (playersField[2, 0] == playerChars))
                        )
                    {
                        if (playerChars == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!!");
                        }

                        Console.WriteLine("Press any key to restart the game!!!!");
                        Console.WriteLine("Or ctrl+C to exit the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turn == 10)
                    {
                        Console.WriteLine("No one is the winner");
                        Console.WriteLine("Press any key to restart the game!!!!");
                        Console.WriteLine("Or ctrl+C to exit the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }

                do
                {
                    Console.WriteLine("Player {0}: make your choose. ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!!!!");
                    }
                    if ((input == 1) && (playersField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playersField[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playersField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playersField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playersField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playersField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playersField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playersField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playersField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\nThis field is already taken, please choose another one");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);

            } while (true);

        }

        public static void ResetField()
        {
            char[,] playerFieldStrat =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            playersField = playerFieldStrat;
            SetField();
            turn = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playersField[0, 0], playersField[0, 1], playersField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playersField[1, 0], playersField[1, 1], playersField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playersField[2, 0], playersField[2, 1], playersField[2, 2]);
            Console.WriteLine("     |     |    ");
            turn++;
        }

        public static void EnterSymbol(int player, int input)
        {
            char signe = ' ';

            if (player == 1)
            {
                signe = 'X';
            }
            else if (player == 2)
            {
                signe = 'O';
            }

            switch (input)
            {
                case 1:
                    playersField[0, 0] = signe;
                    break;
                case 2:
                    playersField[0, 1] = signe;
                    break;
                case 3:
                    playersField[0, 2] = signe;
                    break;
                case 4:
                    playersField[1, 0] = signe;
                    break;
                case 5:
                    playersField[1, 1] = signe;
                    break;
                case 6:
                    playersField[1, 2] = signe;
                    break;
                case 7:
                    playersField[2, 0] = signe;
                    break;
                case 8:
                    playersField[2, 1] = signe;
                    break;
                case 9:
                    playersField[2, 2] = signe;
                    break;
            }
        }
    }
}